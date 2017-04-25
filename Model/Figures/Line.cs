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
        private bool isVertical;
        private CartesianCoordinates point0;
        private CartesianCoordinates point1;
        private decimal slope;
        private decimal yIntercept;
        private double xValue;


        public Line(CartesianCoordinates point0, CartesianCoordinates point1)
        {
            this.point0 = point0;
            this.point1 = point1;
            if (this.point1.X == this.point0.X)
            {
                this.isVertical = true;
                this.xValue = this.point0.X;
            }
            else
            {   //Operations done with decimal precision to further avoid rounding errors.
                this.slope = ((Convert.ToDecimal(this.point1.Y) - Convert.ToDecimal(this.point0.Y)) / (Convert.ToDecimal(this.point1.X) - Convert.ToDecimal(this.point0.X)));
                this.yIntercept = Convert.ToDecimal(this.point1.Y) - Convert.ToDecimal(this.slope) * Convert.ToDecimal(this.point1.X);
            }
        }

        public bool Contains(CartesianCoordinates checkPoint)
        {
            if (this.isVertical)
                return checkPoint.X == this.xValue;
            else
                return Convert.ToDecimal(checkPoint.Y) == this.slope * Convert.ToDecimal(checkPoint.X) + this.yIntercept;
        }

    }
}
