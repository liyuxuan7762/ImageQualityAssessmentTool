
namespace ImageQualityAssessmentTool
{
    partial class FrmMOS
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
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurrentImage = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.MOS});
            this.dgvShow.Location = new System.Drawing.Point(25, 47);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowTemplate.Height = 25;
            this.dgvShow.Size = new System.Drawing.Size(356, 426);
            this.dgvShow.TabIndex = 0;
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Img";
            this.Img.HeaderText = "文件名";
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // MOS
            // 
            this.MOS.DataPropertyName = "MOS";
            this.MOS.HeaderText = "MOS";
            this.MOS.Name = "MOS";
            this.MOS.ReadOnly = true;
            // 
            // lblCurrentImage
            // 
            this.lblCurrentImage.AutoSize = true;
            this.lblCurrentImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentImage.Location = new System.Drawing.Point(149, 9);
            this.lblCurrentImage.Name = "lblCurrentImage";
            this.lblCurrentImage.Size = new System.Drawing.Size(106, 35);
            this.lblCurrentImage.TabIndex = 13;
            this.lblCurrentImage.Text = "MOS值";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(119, 479);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(149, 34);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "将数据导出到Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmMOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 526);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCurrentImage);
            this.Controls.Add(this.dgvShow);
            this.Name = "FrmMOS";
            this.Text = "图像质量主观评价系统V1.0：计算MOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label lblCurrentImage;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOS;
    }
}