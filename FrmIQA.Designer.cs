
namespace ImageQualityAssessmentTool
{
    partial class FrmIQA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnGreater = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnWeaker = new System.Windows.Forms.Button();
            this.lblCurrentImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(804, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 668);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnGreater
            // 
            this.BtnGreater.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGreater.Location = new System.Drawing.Point(702, 279);
            this.BtnGreater.Name = "BtnGreater";
            this.BtnGreater.Size = new System.Drawing.Size(75, 39);
            this.BtnGreater.TabIndex = 5;
            this.BtnGreater.Text = ">";
            this.BtnGreater.UseVisualStyleBackColor = true;
            this.BtnGreater.Click += new System.EventHandler(this.BtnGreater_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEqual.Location = new System.Drawing.Point(702, 324);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(75, 39);
            this.BtnEqual.TabIndex = 10;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnWeaker
            // 
            this.BtnWeaker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWeaker.Location = new System.Drawing.Point(702, 369);
            this.BtnWeaker.Name = "BtnWeaker";
            this.BtnWeaker.Size = new System.Drawing.Size(75, 38);
            this.BtnWeaker.TabIndex = 11;
            this.BtnWeaker.Text = "<";
            this.BtnWeaker.UseVisualStyleBackColor = true;
            this.BtnWeaker.Click += new System.EventHandler(this.BtnWeaker_Click);
            // 
            // lblCurrentImage
            // 
            this.lblCurrentImage.AutoSize = true;
            this.lblCurrentImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentImage.Location = new System.Drawing.Point(508, 9);
            this.lblCurrentImage.Name = "lblCurrentImage";
            this.lblCurrentImage.Size = new System.Drawing.Size(544, 35);
            this.lblCurrentImage.TabIndex = 12;
            this.lblCurrentImage.Text = "当前场景：灯塔；当前正在给第2号图像打分";
            // 
            // FrmIQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 744);
            this.Controls.Add(this.lblCurrentImage);
            this.Controls.Add(this.BtnWeaker);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnGreater);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmIQA";
            this.Text = "图像质量主观评价系统V1.0：无参考评价";
            this.Load += new System.EventHandler(this.FrmIQA_Load);
            this.SizeChanged += new System.EventHandler(this.FrmIQA_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnGreater;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnWeaker;
        private System.Windows.Forms.Label lblCurrentImage;
    }
}

