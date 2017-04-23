using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class PolarCoordinates
    {
        public int Angle { get; set; }
        public int Distance { get; set; }

        public PolarCoordinates(int initialAngle, int initialDistance)
        {
            this.Angle = initialAngle;
            this.Distance = initialDistance;
        }

        internal void Increaseangle(int increment)
        {
            var newAngle = (this.Angle + increment) % 360; 

            if (newAngle < 0)
            {
                newAngle += 360; //Para trabajar con angulos positivos
            }

            this.Angle = newAngle;
        }
    }
}