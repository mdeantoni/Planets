using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using DataAccess;

namespace Services.WeatherConditions
{
    public class WeatherConditionService : IWeatherConditionService
    {
        private IWeatherConditionRepository Repository;

        public WeatherConditionService(IWeatherConditionRepository repository)
        {
            this.Repository = repository;
        }

        public IList<WeatherCondition> GetAll()
        {
            return this.Repository.GetAll();
        }
    }
}
