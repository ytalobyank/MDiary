using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDiary.Models
{
    public class Activity
    {
        public string Description { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int TimeSpent { get; set; }
    }
}
