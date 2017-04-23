using Model.Entities;
using Planets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Observer
{
    /// <summary>
    /// Los planetas se encuentran alineadas entre si, y tambien con respecto al sol, si todos sus angulos son el mismo, o opuestos.
    /// </summary>
    public class DroughtObserver : IObserver<SolarSystem>
    {
        private IList<Drought> droughts;

        public DroughtObserver()
        {
            this.droughts = new List<Drought>();
        }

        public void Update(SolarSystem solarsystem)
        {
            var planets = solarsystem.GetPlanets();
            var angles = planets.Select(x => x.GetPosition().GetAngle());

            var firstAngle = planets.First().GetPosition().GetAngle();

            if (angles.All(x => x.Equals(firstAngle) || x.IsOposite(firstAngle)))
                droughts.Add(new Drought(solarsystem.GetDay()));

        }
    }
}
