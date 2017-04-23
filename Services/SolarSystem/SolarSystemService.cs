using Planets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Services
{
    public class SolarSystemService : ISolarSystemService
    {
        public void DoStuff()
        {
            var ferengi = new Planet("Ferengi", new PolarCoordinates(0, 500), -1);
            var betasoide = new Planet("Betasoide", new PolarCoordinates(0, 2000), -3);
            var vulcano = new Planet("Vulcano", new PolarCoordinates(0, 1000), 10);

            var solarSystem = new SolarSystem(new List<Planet>() { ferengi, betasoide, vulcano });
        }
    }
}