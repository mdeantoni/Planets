using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.WeatherEntities
{
    public class RegularWeatherCondition : WeatherCondition
    {
        public RegularWeatherCondition()
        { 
        }

        public RegularWeatherCondition(int day)
        {
            this.Day = day;
        }

        public override string GetDescription()
        {
            return String.Empty;
        }
    }
}
