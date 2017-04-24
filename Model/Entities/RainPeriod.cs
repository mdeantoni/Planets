using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class RainPeriod
    {
        public RainPeriod(int day, double intensity)
        {
            this.Day = day;
            this.Intensity = intensity;
        }

        public int Day { get; set; }

        public double Intensity { get; set; }
    }
}
