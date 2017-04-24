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
        private List<RainPeriod> Rains;

        public RainObserver()
        {
            this.Rains = new List<RainPeriod>();
        }

        public void Update(SolarSystem solarsystem)
        {
            var planets = solarsystem.GetPlanets();
            var planetCoordinates = planets.Select(x => x.GetPosition().ToCartesian()).ToList();

            var triangle = new Triangle(planetCoordinates[0], planetCoordinates[1], planetCoordinates[2]);

            if (triangle.Contains(solarsystem.GetSunCoordinates()))
            {
                this.Rains.Add(new RainPeriod(solarsystem.GetDay(), triangle.GetPerimeter()));
            }
        }
    }
}
