using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class OptimalConditions : WeatherCondition
    {
        public OptimalConditions()
        {
        }

          public OptimalConditions(int day)
        {
            this.Day = day;
        }

        public override string GetDescription()
        {
            return "Condiciones Optimas";
        }
    }
}
