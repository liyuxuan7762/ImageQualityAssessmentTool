
namespace ImageQualityAssessmentTool
{
    partial class FrmIQA_Ref
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
            this.picRef = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnWeaker = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnGreater = new System.Windows.Forms.Button();
            this.lblCurrentImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picRef
            // 
            this.picRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRef.Location = new System.Drawing.Point(12, 93);
            this.picRef.Name = "picRef";
            this.picRef.Size = new System.Drawing.Size(349, 345);
            this.picRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRef.TabIndex = 1;
            this.picRef.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(367, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(803, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 345);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // BtnWeaker
            // 
            this.BtnWeaker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWeaker.Location = new System.Drawing.Point(722, 271);
            this.BtnWeaker.Name = "BtnWeaker";
            this.BtnWeaker.Size = new System.Drawing.Size(75, 38);
            this.BtnWeaker.TabIndex = 14;
            this.BtnWeaker.Text = "<";
            this.BtnWeaker.UseVisualStyleBackColor = true;
            this.BtnWeaker.Click += new System.EventHandler(this.BtnWeaker_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEqual.Location = new System.Drawing.Point(722, 226);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(75, 39);
            this.BtnEqual.TabIndex = 13;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnGreater
            // 
            this.BtnGreater.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGreater.Location = new System.Drawing.Point(722, 181);
            this.BtnGreater.Name = "BtnGreater";
            this.BtnGreater.Size = new System.Drawing.Size(75, 39);
            this.BtnGreater.TabIndex = 12;
            this.BtnGreater.Text = ">";
            this.BtnGreater.UseVisualStyleBackColor = true;
            this.BtnGreater.Click += new System.EventHandler(this.BtnGreater_Click);
            // 
            // lblCurrentImage
            // 
            this.lblCurrentImage.AutoSize = true;
            this.lblCurrentImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentImage.Location = new System.Drawing.Point(296, 29);
            this.lblCurrentImage.Name = "lblCurrentImage";
            this.lblCurrentImage.Size = new System.Drawing.Size(544, 35);
            this.lblCurrentImage.TabIndex = 15;
            this.lblCurrentImage.Text = "当前场景：灯塔；当前正在给第2号图像打分";
            // 
            // FrmIQA_Ref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 452);
            this.Controls.Add(this.lblCurrentImage);
            this.Controls.Add(this.BtnWeaker);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnGreater);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picRef);
            this.Name = "FrmIQA_Ref";
            this.Text = "图像质量主观评价系统V1.0：有参考评价";
            this.Load += new System.EventHandler(this.FrmIQA_Ref_Load);
            this.SizeChanged += new System.EventHandler(this.FrmIQA_Ref_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRef;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnWeaker;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnGreater;
        private System.Windows.Forms.Label lblCurrentImage;
    }
}