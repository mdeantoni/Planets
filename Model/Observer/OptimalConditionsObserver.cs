using Model.Entities;
using Model.Figures;
using Planets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Observer
{
    public class OptimalConditionsObserver : IObserver<SolarSystem>
    {
        private WeatherConditionCollection collection;
        private List<OptimalConditions> optimalConditions;

        public OptimalConditionsObserver(WeatherConditionCollection collection)
        {
            this.optimalConditions = new List<OptimalConditions>();
            this.collection = collection;
        }


        public void Update(SolarSystem solarSystem)
        {
            var planets = solarSystem.GetPlanets();
            var planetCoordinates = planets.Select(x => x.GetPosition().ToCartesian()).ToList();

            var line = new Line(planetCoordinates[0], planetCoordinates[1]);

            if (line.Contains(planetCoordinates[2]) && !line.Contains(solarSystem.GetSunCoordinates())) //If it contains the sun cordinates then its a drought
            {
                var optimalCondition = new OptimalConditions(solarSystem.GetDay());
                this.optimalConditions.Add(optimalCondition);
                this.collection.Add(optimalCondition);
            }
        }
    }
}
