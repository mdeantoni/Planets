using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PlanetsContext : DbContext
    {
        public PlanetsContext() : base()
        {
            Database.SetInitializer<PlanetsContext>(new DropCreateDatabaseAlways<PlanetsContext>());
        }

        public DbSet<WeatherCondition> WeatherConditions { get; set; }
    }
}
