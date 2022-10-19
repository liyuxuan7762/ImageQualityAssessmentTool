using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageQualityAssessmentTool
{
    public partial class FrmMOS : Form
    {
        public FrmMOS(List<RatedImage> mosList)
        {
            InitializeComponent();

            // 设置dgv
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.Columns["MOS"].DefaultCellStyle.Format = "0.0000";
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvShow.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvShow.EnableHeadersVisualStyles = false;
            this.dgvShow.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
            this.dgvShow.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dgvShow.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


            this.dgvShow.DataSource = mosList;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dgvShow.DataSource == null | this.dgvShow.Rows.Count == 0)
            {
                MessageBox.Show("当前数据为空");
            }

            Export(this.dgvShow);
        }

        private void Export(DataGridView dgv)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel文件|*.xlsx|Excel(2003文件)|*.xls";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks workbooks = application.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Worksheets[1];
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
    }
}
