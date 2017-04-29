using DataAccess;
using Model.Entities;
using Model.Observer;
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
            var vulcano = new Planet("Vulcano", new PolarCoordinates(0, 1000), 5);

            var solarSystem = new SolarSystem(new List<Planet>() { ferengi, betasoide, vulcano });
            var weatherCollection = new WeatherConditionCollection();

            var droughtObserver = new DroughtObserver(weatherCollection);
            var rainObserver = new RainObserver(weatherCollection);
            var optimalCondObserver = new OptimalConditionsObserver(weatherCollection);

            solarSystem.AddObserver(droughtObserver);
            solarSystem.AddObserver(rainObserver);
            solarSystem.AddObserver(optimalCondObserver);

            for (var i = 1; i < 3650; i++)
            {
                solarSystem.ForwardOneDay();
            }

            var repository = new WeatherConditionRepository();
            repository.Persist(weatherCollection.GetAll());
        }
    }
}