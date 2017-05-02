using Planets.Services;
using Planets.ViewModels;
using Services.WeatherConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;

namespace Planets.Controllers
{
    public class ClimaController : ApiController
    {
        private IWeatherConditionService service;

        public ClimaController(IWeatherConditionService service)
        {
            this.service = service;
        }

        public IHttpActionResult Get([FromUri]ClimateRequest request)
        {
            if (ModelState.IsValid)
            {
                var climateCondition = this.service.GetForDay(request.Dia);
                return Json(new ClimateResponse { Clima = climateCondition.GetDescription(), Dia = climateCondition.Day });
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
