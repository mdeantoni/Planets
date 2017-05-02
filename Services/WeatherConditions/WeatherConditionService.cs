using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using DataAccess;
using Model.WeatherEntities;

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

        public WeatherCondition GetForDay(int dia)
        {
            var climate = this.Repository.GetForDay(dia);

            if (climate == null) //If none if found, we can asume that day nothing special happened.
                return new RegularWeatherCondition(dia);

            return climate;
        }
    }
}
