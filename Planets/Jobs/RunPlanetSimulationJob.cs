using Planets.Services;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Jobs
{
    public class RunPlanetSimulationJob : IJob
    {
        private ISolarSystemService solarSystemService;

        public RunPlanetSimulationJob(ISolarSystemService solarSystemService)
        {
            this.solarSystemService = solarSystemService;
        }

        public void Execute(IJobExecutionContext context)
        {
            this.solarSystemService.RunSimulation();
        }
    }
}