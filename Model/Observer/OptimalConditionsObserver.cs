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
        private List<OptimalConditions> OptimalConditions;

        public OptimalConditionsObserver()
        {
            this.OptimalConditions = new List<OptimalConditions>();
        }


        public void Update(SolarSystem solarSystem)
        {
            var planets = solarSystem.GetPlanets();
            var planetCoordinates = planets.Select(x => x.GetPosition().ToCartesian()).ToList();

            var line = new Line(planetCoordinates[0], planetCoordinates[1]);

            if (line.Contains(planetCoordinates[2]) && !line.Contains(solarSystem.GetSunCoordinates())) //If it contains the sun cordinates then its a drought
            {
                this.OptimalConditions.Add(new OptimalConditions(solarSystem.GetDay()));
            }
        }
    }
}
