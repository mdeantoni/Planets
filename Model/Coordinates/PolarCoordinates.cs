using Model.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class PolarCoordinates
    {
        private Angle angle { get; set; }
        private int distance { get; set; }

        public PolarCoordinates(int initialAngle, int initialDistance)
        {
            this.angle = new Angle(initialAngle);
            this.distance = initialDistance;
        }

        public void IncreaseAngle(int increment)
        {
            this.angle.Add(increment);
        }

        public Angle GetAngle()
        {
            return angle;
        }
    }
}