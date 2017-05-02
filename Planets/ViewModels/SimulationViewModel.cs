using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.ViewModels
{
    public class SimulationViewModel
    {
        public int RainyDays { get; set; }

        public int DroughtDays { get; set; }

        public int OptimalDays { get; set; }

        public int MaxRainDay { get; set; }        
    }
}