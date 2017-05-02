﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Drought : WeatherCondition
    {
        public Drought()
        {
        }

        public Drought(int day)
        {
            this.Day = day;
        }

        public override string GetDescription()
        {
            return "Sequia";
        }
    }
}
