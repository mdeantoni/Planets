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
        public IList<WeatherCondition> GetAll()
        {
            using (var db = new PlanetsContext())
            {
                return db.WeatherConditions.ToList();
            }
        }

        public WeatherCondition GetForDay(int day)
        {
            using (var db = new PlanetsContext())
            {
                return db.WeatherConditions.Where(x => x.Day == day).SingleOrDefault();
            }
        }

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
