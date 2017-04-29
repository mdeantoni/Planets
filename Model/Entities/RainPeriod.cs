using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class RainPeriod : WeatherCondition
    {
        public RainPeriod(int day, double intensity)
        {
            this.Day = day;
            this.Intensity = intensity;
        }

        public double Intensity { get; set; }
    }
}
