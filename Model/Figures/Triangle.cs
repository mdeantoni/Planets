using Planets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Figures
{
    public class Triangle
    {
        private CartesianCoordinates point0;
        private CartesianCoordinates point1;
        private CartesianCoordinates point2;

        public Triangle(CartesianCoordinates point0, CartesianCoordinates point1, CartesianCoordinates point2)
        {
            this.point0 = point0;
            this.point1 = point1;
            this.point2 = point2;
        }

        public double GetPerimeter()
        {
            var p01distance = Math.Sqrt(Math.Pow((point1.X - point0.X), 2) + Math.Pow((point1.Y - point0.Y), 2));
            var p12distance = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
            var p20distance = Math.Sqrt(Math.Pow((point2.X - point0.X), 2) + Math.Pow((point2.Y - point0.Y), 2));
            return p01distance + p12distance + p20distance;
        }

        public bool Contains(CartesianCoordinates point)
        {
            var Area = ((double)1 / 2) * (-point1.Y * point2.X + point0.Y * (-point1.X + point2.X) + point0.X * (point1.Y - point2.Y) + point1.X * point2.Y);
            var sign = Area < 0 ? -1 : 1;
            var s = (point0.Y * point2.X - point0.X * point2.Y + (point2.Y - point0.Y) * point.X + (point0.X - point2.X) * point.Y) * sign;
            var t = (point0.X * point1.Y - point0.Y * point1.X + (point0.Y - point1.Y) * point.X + (point1.X - point0.X) * point.Y) * sign;
            return s > 0 && t > 0 && (s + t) < 2 * Area * sign;
        }
  
    }
}
