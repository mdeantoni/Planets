using Model.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class PolarCoordinates
    {
        private CartesianCoordinates CartesianEquivalent;
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
            this.CalculateCartesianEquivalent();
        }

        public Angle GetAngle()
        {
            return angle;
        }

        public CartesianCoordinates ToCartesian()
        {
            if (this.CartesianEquivalent == null) //So we dont calculate this each time it is requested with no angle modifications.
            {
                this.CalculateCartesianEquivalent();
            }
            return this.CartesianEquivalent;

        }

        private void CalculateCartesianEquivalent()
        {
            this.CartesianEquivalent = new CartesianCoordinates(this.distance * Math.Cos(this.angle.Value * Math.PI / 180),
                                            this.distance * Math.Sin(this.angle.Value * Math.PI / 180));
        }
    }
}