using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.WeatherConditions
{
    public interface IWeatherConditionService
    {
        IList<WeatherCondition> GetAll();

        WeatherCondition GetForDay(int dia);
    }
}
