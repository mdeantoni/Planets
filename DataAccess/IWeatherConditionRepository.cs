using Model.Entities;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IWeatherConditionRepository
    {
        void Persist(IList<WeatherCondition> conditions);

        IList<WeatherCondition> GetAll();
    }
}