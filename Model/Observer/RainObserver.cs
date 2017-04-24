using Model.Entities;
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

            var solarCoordinates = new CartesianCoordinates(0, 0);
            var p0 = planetCoordinates[0];
            var p1 = planetCoordinates[1];
            var p2 = planetCoordinates[2];

            //This algorithm does not consider inside the triangle points on its edges.
            var Area = ((double)1 / 2) * (-p1.Y * p2.X + p0.Y * (-p1.X + p2.X) + p0.X * (p1.Y - p2.Y) + p1.X * p2.Y);
            var sign = Area < 0 ? -1 : 1;
            var s = (p0.Y * p2.X - p0.X * p2.Y + (p2.Y - p0.Y) * solarCoordinates.X + (p0.X - p2.X) * solarCoordinates.Y) * sign;
            var t = (p0.X * p1.Y - p0.Y * p1.X + (p0.Y - p1.Y) * solarCoordinates.X + (p1.X - p0.X) * solarCoordinates.Y) * sign;
            var containsSun = s > 0 && t > 0 && (s + t) < 2 * Area * sign;

            if (containsSun)
            {
                this.Rains.Add(new RainPeriod(solarsystem.GetDay()));
            }
        }
    }
}
