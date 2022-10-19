using System;
using System.Collections.Generic;
using System.Text;

namespace ImageQualityAssessmentTool
{
    public class RatedImage
    {
        public RatedImage(string filename, int order, double score)
        {
            this.Img = filename;
            this.Order = order;
            this.Score = score;
        }

        public RatedImage(string filename, int order, double score, string fileSource)
        {
            this.Img = filename;
            this.Order = order;
            this.Score = score;
            this.FileSource = fileSource;
        }

        public RatedImage(string filename, int order, string fileSource)
        {
            this.Img = filename;
            this.Order = order;
            this.FileSource = fileSource;
        }

        public RatedImage(string filename, int order, string fileSource, string sence)
        {
            this.Img = filename;
            this.Order = order;
            this.FileSource = fileSource;
            this.Sence = sence;
        }

        public RatedImage(string filename, int order, string sence, double score)
        {
            this.Img = filename;
            this.Order = order;
            this.Sence = sence;
            this.Score = score;
        }

        public RatedImage(string filename, double mos, bool isMOS)
        {
            this.Img = filename;
            if(isMOS)
            {
                this.MOS = mos;
            }
            else
            {
                this.Score = mos;
            }
        }

        public string Img { get; set; }

        public int Order { get; set; }

        public string Sence { get; set; } = "场景1";

        public double Score { get; set; }

        public double MOS { get; set; }

        public string FileSource { get; set; }

    }
}
