using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;


namespace ImageQualityAssessmentTool
{
    public partial class FrmTest : Form
    {
        private Image[] images; // 排序前的图像序列
        private Image[] D_S; // 排序后的图像序列
        private int[] R;  // 图像的顺序
        private string[] fileName;
        private int h;
        private int k;

        private int start;
        private int end;
        private int mid;

        private bool isReferenceExist = false; // 用来标记是否为NR或者FR NR为false，FR为true
        private Image reference;

        private double[] ScoreValue;

        private List<RatedImage> allImageList; // 存储从excel中读取的所有记录

        public FrmTest()
        {
            InitializeComponent();

            // dgv相关属性设置
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.Columns["Score"].DefaultCellStyle.Format = "0.0000";
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvShow.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvShow.EnableHeadersVisualStyles = false;
            this.dgvShow.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
            this.dgvShow.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dgvShow.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void BtnDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string dir = folderBrowserDialog.SelectedPath;
                this.txtDir.Text = dir;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // 首先先默认为NRIQA方法
            isReferenceExist = false;

            List<RatedImage> ratedImagesList = new List<RatedImage>();
            List<Image> re_sortImageList = new List<Image>();
            List<string> subFolderList = new List<string>();

            if (this.txtDir.Text.Trim() == "")
            {
                MessageBox.Show("请先选择目录再加载图像");
                return;
            }

            // 判断是否为多场景
            if (this.cbSubFolder.Checked == true)
            {
                List<RatedImage> mulitSenceRatedImageList = new List<RatedImage>();
                // 首先获取到所有的子目录
                string dirname = this.txtDir.Text.Trim();
                string[] dirs = Directory.GetDirectories(dirname);
                foreach (string item in dirs)
                {
                    // subFolderList保存所有子目录的绝对路径
                    subFolderList.Add(dirname + "\\" + Path.GetFileNameWithoutExtension(item));
                }

                foreach (string subfolder in subFolderList)
                {
                    ratedImagesList.Clear();
                    int imageNum = LoadData(subfolder);
                    Rating(imageNum, isReferenceExist);
                    int i = 1;
                    // 封装排序后的图像到图像序列
                    foreach (string filename in fileName)
                    {
                        // 提取出文件的文件名
                        string file = Path.GetFileName(filename);
                        string senceName = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(filename));
                        int order = R[i];
                        ratedImagesList.Add(new RatedImage(file, order, filename, senceName));
                        i++;
                    }
                    ratedImagesList = (from item in ratedImagesList orderby item.Sence ascending, item.Order ascending select item).ToList();

                    mulitSenceRatedImageList.AddRange(Resort(ratedImagesList, re_sortImageList));
                }
                this.dgvShow.DataSource = mulitSenceRatedImageList;
            }
            else
            {
                // 不包含子文件夹
                int imageNum = LoadData(this.txtDir.Text.Trim());
                Rating(imageNum, isReferenceExist);
                int i = 1;
                // 封装排序后的图像到图像序列
                foreach (string filename in fileName)
                {
                    // 提取出文件的文件名
                    string file = Path.GetFileName(filename);
                    string senceName = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(filename));
                    int order = R[i];
                    ratedImagesList.Add(new RatedImage(file, order, filename, senceName));
                    i++;
                }
                ratedImagesList = (from item in ratedImagesList orderby item.Order ascending select item).ToList();

                // 第一轮打分结束，遍历排名中重复超过2次的图片，进行重新打分
                // 查找R数组中重复的排序号

                // 在DGV中展示打分结果

                this.dgvShow.DataSource = Resort(ratedImagesList, re_sortImageList);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtDir.Text = "";
            this.dgvShow.DataSource = null;
            this.dgvShow.Refresh();
            this.isReferenceExist = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dgvShow.DataSource == null | this.dgvShow.Rows.Count == 0)
            {
                MessageBox.Show("当前数据为空");
            }

            Export(this.dgvShow);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            allImageList = new List<RatedImage>();

            // 根据输入的excel文件计算生成每一个图片的MOS值
            if (this.txtExcel.Text.Trim() == "")
            {
                MessageBox.Show("请先选择Excel文件所在目录");
                return;
            }

            // 判断所选目录中是否存在excel文件
            List<string> fileList = LoadExcel(this.txtExcel.Text.Trim());
            if (fileList.Count == 0)
            {
                MessageBox.Show("所选目录未找到Excel文件，请检查后重试");
                return;
            }

            // 根据filelist中的目录依次读取
            foreach (string file in fileList)
            {
                // 遍历所有的excel文件，将excel文件添加到excel
                AddImageToAllImageList(file);
            }

            //计算MOS值
            List<RatedImage> mosList = CalculatingMOS(allImageList);

            // 将结果在新窗口的DGV中显示
            FrmMOS frmMOS = new FrmMOS(mosList);
            frmMOS.StartPosition = FormStartPosition.CenterParent;
            DialogResult dialogResult = frmMOS.ShowDialog();


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string dir = folderBrowserDialog.SelectedPath;
                this.txtExcel.Text = dir;
            }
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否要关闭", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true; //这里表示取消退出 
            }
        }

        private void Export(DataGridView dgv)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel文件|*.xlsx|Excel(2003文件)|*.xls";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                Excel.Application application = new Excel.Application();
                Excel.Workbooks workbooks = application.Workbooks;
                Excel.Workbook workbook = workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet worksheet = workbook.Worksheets[1];
                int colIndex = 0;
                //导出DataGridView中的标题
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (dgv.Columns[i].Visible)//做同于不导出隐藏列
                    {
                        colIndex++;
                        worksheet.Cells[1, colIndex] = dgv.Columns[i].HeaderText;
                    }
                }
                //导出DataGridView中的数据
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    colIndex = 0;
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv.Columns[j].Visible)
                        {
                            colIndex++;
                            worksheet.Cells[i + 2, colIndex] = "'" + dgv.Rows[i].Cells[j].Value;
                        }
                    }
                }
                //保存文件
                workbook.SaveAs(fileDialog.FileName);
                application.Quit();
                MessageBox.Show("导出成功");
            }
        }

        private int LoadData(string filedir)
        {
            #region 根据用户选定目录，获得所有待评价图片的路径，存储在fileList中

            DirectoryInfo dir = new DirectoryInfo(filedir);
            List<string> fileList = new List<string>();
            List<Image> imageList = new List<Image>();
            List<int> Rlist = new List<int>();
            List<Image> D_SList = new List<Image>();

            try
            {
                foreach (FileInfo NextFIle in dir.GetFiles())
                {
                    string fileExt = NextFIle.Extension;
                    if (fileExt == ".jpeg" | fileExt == ".png" | fileExt == ".jpg" | fileExt == ".bmp")
                    {
                        // 判断是否存在reference image
                        if (Path.GetFileNameWithoutExtension(NextFIle.FullName) == "ref")
                        {
                            isReferenceExist = true;
                            reference = Image.FromFile(NextFIle.FullName);
                            continue;
                        }
                        fileList.Add(NextFIle.FullName);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "读取数据异常", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (fileList.Count == 0)
            {
                MessageBox.Show("所选目录没有文件或没有指定图像文件，请检查后重试");
                return -1;
            }
            #endregion

            #region fileList路径将所有图像读入imageList中
            Image image = null;
            imageList.Add(image);
            D_SList.Add(image);
            Rlist.Add(0);

            foreach (string file in fileList)
            {
                imageList.Add(Image.FromFile(file));
                D_SList.Add(image);
                Rlist.Add(0);
            }
            #endregion

            // 将列表转为数组
            D_S = D_SList.ToArray();
            R = Rlist.ToArray();
            images = imageList.ToArray();
            fileName = fileList.ToArray();

            return fileList.Count;
        }

        private void Rating(int imageNum, bool isReferenceExists)
        {
            // 初始化
            D_S[1] = images[1];
            R[1] = 1;
            h = 1;

            for (int i = 2; i <= imageNum; i++)
            {
                start = 1;
                end = h;
                while (start <= end)
                {
                    mid = Convert.ToInt32((Math.Floor(Convert.ToDouble((start + end) / 2))));
                    // 显示图像
                    DialogResult dialogResult;
                    if (isReferenceExists == false)
                    {
                        FrmIQA frmIQA = new FrmIQA(D_S[mid], images[i], i);
                        frmIQA.StartPosition = FormStartPosition.CenterParent;
                        frmIQA.WindowState = FormWindowState.Maximized;
                        // OK  >  Cancel =  Yes <
                        dialogResult = frmIQA.ShowDialog();
                    }
                    else
                    {
                        FrmIQA_Ref frmIQA_Ref = new FrmIQA_Ref(D_S[mid], images[i], i, reference);
                        frmIQA_Ref.StartPosition = FormStartPosition.CenterParent;
                        frmIQA_Ref.WindowState = FormWindowState.Maximized;
                        dialogResult = frmIQA_Ref.ShowDialog();
                    }


                    if (dialogResult == DialogResult.Cancel)
                    {
                        start = mid;
                        break;
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        end = mid - 1;
                    }
                    if (dialogResult == DialogResult.OK)
                    {
                        start = mid + 1;
                    }
                }

                k = start;
                // 更新R
                if (start > end)
                {
                    R[i] = k;
                    for (int g = 1; g <= i - 1; g++)
                        if (R[g] >= k)
                            R[g] = R[g] + 1;


                    // 更新D_S
                    if (h >= k)
                    {
                        for (int g = h; g >= k; g--)
                            D_S[g + 1] = D_S[g];
                    }

                    D_S[k] = images[i];
                    h++;
                }
                else
                {
                    R[i] = k;
                }
            }
        }

        private void CalculatingScore()
        {
            int max = R.Skip(1).Max();
            int denominator = R.Skip(1).Max() - R.Skip(1).Min();
            List<double> ScoreList = new List<double>();
            ScoreList.Add(0.0);
            // 计算MOS
            foreach (int r in R.Skip(1))
            {
                double score = (max - r) / (denominator + 0.0) * 9;
                ScoreList.Add(score);
            }

            ScoreValue = ScoreList.ToArray();

        }

        private void CalculatingScore(List<RatedImage> rateImageList)
        {
            List<int> RList = new List<int>();
            foreach (RatedImage img in rateImageList)
            {
                RList.Add(img.Order);
            }
            int[] RArray = RList.ToArray();

            int max = RArray.Max();
            int denominator = RArray.Max() - RArray.Min();
            List<double> ScoreList = new List<double>();
            ScoreList.Add(0.0);
            // 计算MOS
            foreach (int r in RArray)
            {
                double score = (max - r) / (denominator + 0.0) * 9;
                ScoreList.Add(score);
            }
            ScoreValue = ScoreList.ToArray();
        }
        /// <summary>
        /// 返回一个列表，每一项存储的是一个excel文件的路径
        /// </summary>
        /// <param name="filedir"></param>
        /// <returns></returns>
        private List<string> LoadExcel(string filedir)
        {
            DirectoryInfo dir = new DirectoryInfo(filedir);
            List<string> fileList = new List<string>();

            try
            {
                foreach (FileInfo NextFile in dir.GetFiles())
                {
                    // 判断文件是否为excel
                    string ext = NextFile.Extension;
                    if (ext == ".xls" | ext == ".xlsx")
                    {
                        fileList.Add(NextFile.FullName);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "读取数据异常", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return fileList;
        }

        /// <summary>
        /// 需要传入的参数是所有人对所有图像的评价
        /// </summary>
        /// <param name="totalImageList"></param>
        private List<RatedImage> CalculatingMOS(List<RatedImage> allImageList)
        {
            List<RatedImage> mosList = new List<RatedImage>();
            // 根据所有的图片 根据图片的名称分类，求每一个图片的平均分MOS
            var imageList = from p in allImageList
                            group p by p.Img into g
                            select new
                            {
                                g.Key,
                                MOS = g.Average(p => p.Score)
                            };
            foreach (var p in imageList)
            {
                mosList.Add(new RatedImage(p.Key, p.MOS, true));
            }
            // mosList 中存放了所有的图像文件名和对应的MOS值

            return mosList;
        }

        private static DataTable GetExcelTableByOleDB(string strExcelPath, string tableName)
        {
            try
            {
                DataTable dtExcel = new DataTable();
                //数据表
                DataSet ds = new DataSet();
                //获取文件扩展名
                string strExtension = System.IO.Path.GetExtension(strExcelPath);
                string strFileName = System.IO.Path.GetFileName(strExcelPath);
                //Excel的连接
                OleDbConnection objConn = null;
                switch (strExtension)
                {
                    case ".xls":
                        objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 8.0;HDR=yes;IMEX=1;\"");
                        break;
                    case ".xlsx":
                        objConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 12.0;HDR=yes;IMEX=1;\"");//此连接可以操作.xls与.xlsx文件 (支持Excel2003 和 Excel2007 的连接字符串)  备注： "HDR=yes;"是说Excel文件的第一行是列名而不是数，"HDR=No;"正好与前面的相反。"IMEX=1 "如果列中的数据类型不一致，使用"IMEX=1"可必免数据类型冲突。 
                        break;
                    default:
                        objConn = null;
                        break;
                }
                if (objConn == null)
                {
                    return null;
                }
                objConn.Open();
                //获取Excel中所有Sheet表的信息
                //System.Data.DataTable schemaTable = objConn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                //获取Excel的第一个Sheet表名
                // string tableName1 = schemaTable.Rows[0][2].ToString().Trim();
                string strSql = "select * from [" + tableName + "$]";
                //获取Excel指定Sheet表中的信息
                OleDbCommand objCmd = new OleDbCommand(strSql, objConn);
                OleDbDataAdapter myData = new OleDbDataAdapter(strSql, objConn);
                myData.Fill(ds, tableName);//填充数据
                objConn.Close();
                //dtExcel即为excel文件中指定表中存储的信息
                dtExcel = ds.Tables[tableName];
                return dtExcel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        private void AddImageToAllImageList(string file)
        {
            // 获取到整个excel表格中所有记录
            DataTable dt = GetExcelTableByOleDB(file, @"Sheet1");
            foreach (DataRow dataRow in dt.Rows)
            {
                string img = dataRow["文件名"].ToString();
                double score = Convert.ToDouble(dataRow["分数"]);
                allImageList.Add(new RatedImage(img, score, false));
            }
        }

        private List<OrderCount> CheckResort(List<RatedImage> ratedImageList)
        {
            // 从imagelist中获取到排名
            List<int> RList = new List<int>();
            foreach (RatedImage img in ratedImageList)
            {
                RList.Add(img.Order);
            }
            int[] RArray = RList.ToArray();
            Array.Sort(RArray);
            List<OrderCount> orders;
            List<int[]> rank = new List<int[]>()
            {
                RArray
            };
            foreach (var array in rank)
            {
                var list = array.Select(s => new
                {
                    s,
                    c = array.Count(c => c == s)
                }).Distinct().Where(w => w.c > 1);
                if (list.ToList().Count == 0)
                {
                    return null;
                }
                else
                {
                    orders = new List<OrderCount>();
                    foreach (var l in list)
                    {
                        if (l.c > 2)
                        {
                            // 重复次数超过两次，则记录重复的次数
                            orders.Add(new OrderCount(l.s, l.c));
                        }
                    }

                    return orders;
                }

            }
            return null;
        }

        private static int[] DelRepeatData(int[] a)
        {
            return a.GroupBy(p => p).Select(p => p.Key).ToArray();
        }

        private List<RatedImage> Resort(List<RatedImage> ratedImagesList, List<Image> re_sortImageList)
        {
            
            while (true)
            {
                re_sortImageList.Clear();

                List<OrderCount> orders = CheckResort(ratedImagesList);

                if (orders == null || orders.Count == 0)
                {
                    // 没有超过两次的排序号重复，直接显示数据
                    // 在DGV中展示打分结果
                    break;
                }
                else
                {
                    // 有重复，则需要重新打分
                    foreach (OrderCount order in orders)
                    {
                        int orderNum = order.Order; // 重复的排序号
                        int count = order.Count; // 重复次数
                        re_sortImageList.Add(null);
                        List<Image> D_SList = new List<Image>();
                        List<int> Rlist = new List<int>();
                        D_SList.Add(null);
                        Rlist.Add(0);
                        // 遍历整个rateimagelist，从中找到所有的等于该排序号的所有图像对象
                        foreach (RatedImage img in ratedImagesList)
                        {
                            if (img.Order == orderNum)
                            {
                                re_sortImageList.Add(Image.FromFile(img.FileSource));
                                D_SList.Add(null);
                                Rlist.Add(0);
                            }
                        }

                        // 初始化rate需要用到的变量
                        D_S = D_SList.ToArray();
                        R = Rlist.ToArray();
                        images = re_sortImageList.ToArray();

                        // 对排名相同的继续进行打分
                        Rating(count, isReferenceExist);
                        int i = 1;
                        // 更新所有排名
                        int num = DelRepeatData(R.Skip(1).ToArray()).Length;
                        foreach (RatedImage img in ratedImagesList)
                        {
                            if (img.Order < orderNum)
                            {
                                continue;
                            }
                            else if (img.Order > orderNum)
                            {
                                img.Order = img.Order + num - 1;
                            }
                            else
                            {
                                // 重复的序列号
                                img.Order = img.Order + R[i] - 1;
                                i++;
                            }
                        }

                        // 重新按照order对rateImageList进行排序
                        ratedImagesList = (from item in ratedImagesList orderby item.Order ascending select item).ToList();
                        break;
                    }
                }
            }

            // 更新分数
            int j = 1;
            CalculatingScore(ratedImagesList);
            foreach (RatedImage img in ratedImagesList)
            {
                img.Score = ScoreValue[j];
                j++;
            }

            return ratedImagesList;
        }
    }
}
