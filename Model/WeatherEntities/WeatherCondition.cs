﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public abstract class WeatherCondition
    {
        public int WeatherConditionId { get; set; }

        public int Day { get; set; }

        public abstract string GetDescription();
    }
}
