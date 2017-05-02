using Model.Entities;
using MoreLinq;
using Planets.ViewModels;
using Services.WeatherConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planets.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherConditionService service;

        public HomeController(IWeatherConditionService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var allConditions = this.service.GetAll();

            return View(new SimulationViewModel()
            {
                DroughtDays = allConditions.OfType<Drought>().Count(),
                RainyDays = allConditions.OfType<RainPeriod>().Count(),
                OptimalDays = allConditions.OfType<OptimalConditions>().Count(),
                MaxRainDay = allConditions.OfType<RainPeriod>().MaxBy(x => x.Intensity).Day 
            });
        }
    }
}
