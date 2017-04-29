using Planets.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Planets.Controllers
{
    public class ValuesController : ApiController
    {
        private ISolarSystemService solarSystemService;

        public ValuesController(ISolarSystemService service)
        {
            this.solarSystemService = service;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            this.solarSystemService.RunSimulation();
            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
