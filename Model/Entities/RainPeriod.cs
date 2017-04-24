using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class RainPeriod
    {
        public RainPeriod(int day)
        {
            this.Day = day;
        }

        public int Day { get; set; }

        public float Intensity { get; set; }
    }
}
