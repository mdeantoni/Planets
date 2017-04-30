using Planets.App_Start;
using Quartz;
using System;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Jobs
{
    public class JobScheduler
    {
        public static void ScheduleJobs()
        {
            var container = UnityConfig.GetConfiguredContainer();

            IScheduler scheduler = container.Resolve<IScheduler>();
            scheduler.Start();


            IJobDetail job = JobBuilder.Create<RunPlanetSimulationJob>()
                .WithIdentity("SimulationJob", "group1")
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("SimulationTrigger", "group1")
                .StartNow()
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}