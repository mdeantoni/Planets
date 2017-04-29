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
        private IWeatherConditionRepository weatherConditionRepository;

        public SolarSystemService(IWeatherConditionRepository repository)
        {
            this.weatherConditionRepository = repository;
        }

        public void RunSimulation()
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

            solarSystem.AdvanceDays(3650);

            this.weatherConditionRepository.Persist(weatherCollection.GetAll());
        }
    }
}