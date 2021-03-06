﻿using Model.Entities;
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
    /// Se podria haber implementado como parte del obervador de condiciones optimas ( si adicionalmente a satisfacer la condicion de una recta, esta pasa por el 0, pero de esta forma entiendo es mas claro ).
    /// </summary>
    public class DroughtObserver : IObserver<SolarSystem>
    {
        private WeatherConditionCollection collection;
        private IList<Drought> droughts;

        public DroughtObserver(WeatherConditionCollection collection)
        {
            this.droughts = new List<Drought>();
            this.collection = collection;
        }

        public void Update(SolarSystem solarsystem)
        {
            var planets = solarsystem.GetPlanets();
            var angles = planets.Select(x => x.GetPosition().GetAngle());

            var firstAngle = planets.First().GetPosition().GetAngle();

            if (angles.All(x => x.Equals(firstAngle) || x.IsOposite(firstAngle)))
            {
                var drought = new Drought(solarsystem.GetDay());
                droughts.Add(drought);
                this.collection.Add(drought);
            }

        }
    }
}
