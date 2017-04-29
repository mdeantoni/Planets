using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planets.Models;
using Model.Figures;
using FluentAssertions;

namespace Planets.Tests.Models
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_Should_Not_Contain_Points_On_Its_Edges()
        {
            var p0 = new CartesianCoordinates(0,0);
            var p1 = new CartesianCoordinates(2, 0);
            var p2 = new CartesianCoordinates(0, 2);
            var triangle = new Triangle(p0, p1, p2);

            triangle.Contains(new CartesianCoordinates(1, 1)).Should().BeFalse();
            triangle.Contains(new CartesianCoordinates(0, 0.5)).Should().BeFalse();
            triangle.Contains(new CartesianCoordinates(1, 0)).Should().BeFalse();
        }

        [TestMethod]
        public void Triangle_Should_Not_Contain_Its_Vertices()
        {
            var p0 = new CartesianCoordinates(0, 0);
            var p1 = new CartesianCoordinates(2, 0);
            var p2 = new CartesianCoordinates(0, 2);
            var triangle = new Triangle(p0, p1, p2);

            triangle.Contains(p0).Should().BeFalse();
            triangle.Contains(p1).Should().BeFalse();
            triangle.Contains(p2).Should().BeFalse();
        }

        [TestMethod]
        public void Triangle_Should_Contain_Points_Inside_It()
        {
            var p0 = new CartesianCoordinates(0, 0);
            var p1 = new CartesianCoordinates(2, 0);
            var p2 = new CartesianCoordinates(0, 2);
            var triangle = new Triangle(p0, p1, p2);

            triangle.Contains(new CartesianCoordinates(0.99999999999999, 0.99999999999999)).Should().BeTrue();
            triangle.Contains(new CartesianCoordinates(0.00000000000001, 0.00000000000001)).Should().BeTrue();
            triangle.Contains(new CartesianCoordinates(0.5, 0.5)).Should().BeTrue();
        }

        [TestMethod]
        public void Triangle_Should_Do_A_Proper_Calculation_Of_Its_Perimeter()
        {
            var p0 = new CartesianCoordinates(0, 0);
            var p1 = new CartesianCoordinates(2, 0);
            var p2 = new CartesianCoordinates(0, 2);
            var triangle = new Triangle(p0, p1, p2);

            triangle.GetPerimeter().Should().Be(4 + Math.Sqrt(8));
        }
    }
}
