using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageQualityAssessmentTool
{
    public partial class FrmIQA : Form
    {
        AutoResizeForm autoResizeForm = new AutoResizeForm();
        public FrmIQA(Image img1, Image img2, int index)
        {
            InitializeComponent();
            this.pictureBox2.Image = img1;
            this.pictureBox1.Image = img2;

            index = index - 1;
            this.lblCurrentImage.Text = "第" + index + "组图像";

        }

        private void BtnGreater_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnWeaker_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void FrmIQA_Load(object sender, EventArgs e)
        {
            autoResizeForm.controllInitializeSize(this);
        }

        private void FrmIQA_SizeChanged(object sender, EventArgs e)
        {
            autoResizeForm.controlAutoSize(this);
        }
    }
}
