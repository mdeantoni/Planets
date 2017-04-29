using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WeatherConditionRepository : IWeatherConditionRepository
    {
        public void Persist(IList<WeatherCondition> conditions)
        {
            using (var db = new PlanetsContext())
            {
                db.WeatherConditions.AddRange(conditions);
                db.SaveChanges();
            }
        }
    }
}
