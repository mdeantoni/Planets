using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planets.Models;
using Model.Figures;
using FluentAssertions;

namespace Planets.Tests.Models
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void PositiveSlopeLineShouldContainElementsInItsPath()
        {
            var p0 = new CartesianCoordinates(0.03, 2.8);
            var p1 = new CartesianCoordinates(-0.044, -1.64);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(-0.069, -3.14)).Should().BeTrue();
        }

        [TestMethod]
        public void NegativeSlopeLineShouldContainElementsInItsPath()
        {
            var p0 = new CartesianCoordinates(1.5, 0);
            var p1 = new CartesianCoordinates(0, 6);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(0.76, 2.96)).Should().BeTrue();
        }

        [TestMethod]
        public void NegativeSlopeLineShouldNotContainElementsNotInItsPath()
        {
            var p0 = new CartesianCoordinates(1.5, 0);
            var p1 = new CartesianCoordinates(0, 6);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(0.76, 2.97)).Should().BeFalse();
        }

        [TestMethod]
        public void PositiveopeLineShouldNotContainElementsNotInItsPath()
        {
            var p0 = new CartesianCoordinates(0.03, 2.8);
            var p1 = new CartesianCoordinates(-0.044, -1.64);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(-0.069, -3.1399999999999999)).Should().BeTrue();
        }

        [TestMethod]
        public void HorizontalLineShouldContainElementsInItsPath()
        {
            var p0 = new CartesianCoordinates(1, 0);
            var p1 = new CartesianCoordinates(-6, 0);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(10, 0)).Should().BeTrue();
        }

        [TestMethod]
        public void HorizontalLineShouldNotContainElementsNotInItsPath()
        {
            var p0 = new CartesianCoordinates(1, 0);
            var p1 = new CartesianCoordinates(-6, 0);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(10, 0.00000000000001)).Should().BeFalse();
        }

        [TestMethod]
        public void VerticalLineShouldContainElementsInItsPath()
        {
            var p0 = new CartesianCoordinates(6, 10);
            var p1 = new CartesianCoordinates(6, -12);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(6, 0)).Should().BeTrue();
        }

        [TestMethod]
        public void VerticallLineShouldNotContainElementsNotInItsPath()
        {
            var p0 = new CartesianCoordinates(6, 10);
            var p1 = new CartesianCoordinates(6, -12);
            var line = new Line(p0, p1);

            line.Contains(new CartesianCoordinates(5, 0)).Should().BeFalse();
        }
    }
}
