using Planets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Figures
{
    public class Line
    {
        private CartesianCoordinates point0;
        private CartesianCoordinates point1;
        private double slope;
        private double yIntercept;

        public Line(CartesianCoordinates point0, CartesianCoordinates point1)
        {
            this.point0 = point0;
            this.point1 = point1;
            this.slope = (this.point1.Y - this.point0.Y) / (this.point1.X - this.point0.X);
            this.yIntercept = this.point1.Y - this.slope * this.point1.X;
        }

        public bool Contains(CartesianCoordinates checkPoint)
        {
            return checkPoint.Y == this.slope * checkPoint.X + this.yIntercept;
        }

    }
}
