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
    public class RainObserver : IObserver<SolarSystem>
    {
        private WeatherConditionCollection collection;
        private List<RainPeriod> rains;

        public RainObserver(WeatherConditionCollection collection)
        {
            this.rains = new List<RainPeriod>();
            this.collection = collection;
        }

        public void Update(SolarSystem solarsystem)
        {
            var planets = solarsystem.GetPlanets();
            var planetCoordinates = planets.Select(x => x.GetPosition().ToCartesian()).ToList();

            var triangle = new Triangle(planetCoordinates[0], planetCoordinates[1], planetCoordinates[2]);

            if (triangle.Contains(solarsystem.GetSunCoordinates()))
            {
                var rain = new RainPeriod(solarsystem.GetDay(), triangle.GetPerimeter());
                this.rains.Add(rain);
                this.collection.Add(rain);
            }
        }
    }
}
