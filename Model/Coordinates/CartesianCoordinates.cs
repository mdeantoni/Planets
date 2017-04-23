using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class CartesianCoordinates
    {
        public float xCoordinate;
        public float yCoordinate;

        public CartesianCoordinates(float x, float y)
        {
            this.xCoordinate = x;
            this.yCoordinate = y; 
        }
    }
}