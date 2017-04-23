using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class SolarSystem
    {
        private IList<Planet> planets;

        public SolarSystem(IList<Planet> planets)
        {
            this.planets = planets;
        }

        public void ForwardOneDay()
        {
            foreach (var planeta in planets)
            {
                planeta.ForwardOneDay();
            }
        }
    }
}