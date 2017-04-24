using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class CartesianCoordinates
    {
        public double X;
        public double Y;

        public CartesianCoordinates(double x, double y)
        {
            this.X = x;
            this.Y = y; 
        }
    }
}