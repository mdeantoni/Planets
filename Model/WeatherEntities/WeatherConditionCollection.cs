using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class WeatherConditionCollection
    {
        private IList<WeatherCondition> WeatherConditions;

        public WeatherConditionCollection()
        {
            this.WeatherConditions = new List<WeatherCondition>();
        }

        public void Add(WeatherCondition wc)
        {
            this.WeatherConditions.Add(wc);
        }

        public IList<WeatherCondition> GetAll()
        {
            return WeatherConditions;
        }
    }
}
