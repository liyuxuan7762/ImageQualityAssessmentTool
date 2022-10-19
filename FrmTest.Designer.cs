
namespace ImageQualityAssessmentTool
{
    partial class FrmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.BtnDir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSubFolder = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(6, 22);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(641, 23);
            this.txtDir.TabIndex = 1;
            // 
            // BtnDir
            // 
            this.BtnDir.Location = new System.Drawing.Point(653, 22);
            this.BtnDir.Name = "BtnDir";
            this.BtnDir.Size = new System.Drawing.Size(70, 23);
            this.BtnDir.TabIndex = 2;
            this.BtnDir.Text = "选择";
            this.BtnDir.UseVisualStyleBackColor = true;
            this.BtnDir.Click += new System.EventHandler(this.BtnDir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.BtnDir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[评估图像]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(403, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 470);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[使用说明]";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 442);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 35);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "加载图像&&开始";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSubFolder);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 105);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[操作]";
            // 
            // cbSubFolder
            // 
            this.cbSubFolder.AutoSize = true;
            this.cbSubFolder.Location = new System.Drawing.Point(181, 69);
            this.cbSubFolder.Name = "cbSubFolder";
            this.cbSubFolder.Size = new System.Drawing.Size(63, 21);
            this.cbSubFolder.TabIndex = 8;
            this.cbSubFolder.Text = "多场景";
            this.cbSubFolder.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(6, 61);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(149, 34);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "导出评估结果";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清空图像";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.Sence,
            this.Order,
            this.Score});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.Location = new System.Drawing.Point(12, 293);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowTemplate.Height = 25;
            this.dgvShow.Size = new System.Drawing.Size(363, 357);
            this.dgvShow.TabIndex = 7;
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Img";
            this.Img.HeaderText = "文件名";
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // Sence
            // 
            this.Sence.DataPropertyName = "Sence";
            this.Sence.HeaderText = "场景";
            this.Sence.Name = "Sence";
            this.Sence.ReadOnly = true;
            // 
            // Order
            // 
            this.Order.DataPropertyName = "Order";
            this.Order.HeaderText = "排名";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "分数";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalculate);
            this.groupBox4.Controls.Add(this.btnExcel);
            this.groupBox4.Controls.Add(this.txtExcel);
            this.groupBox4.Location = new System.Drawing.Point(12, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(729, 98);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[导入评估结果]";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(717, 38);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "计算MOS均值";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(653, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(70, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "选择";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(6, 22);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(641, 23);
            this.txtExcel.TabIndex = 3;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 663);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTest";
            this.Text = "图像质量主观评价系统V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTest_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button BtnDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox cbSubFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}