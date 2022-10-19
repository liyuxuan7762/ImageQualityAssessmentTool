using System;
using System.Collections.Generic;
using System.Text;

namespace ImageQualityAssessmentTool
{
    public class OrderCount
    {
        public int Order { get; set; }
        public int Count { get; set; }

        public OrderCount(int order, int count)
        {
            this.Order = order;
            this.Count = count;
        }
    }
}
