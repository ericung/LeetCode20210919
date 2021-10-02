using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moderate.Problem03;
using System;

namespace ModerateTests.Problem03
{
    [TestClass]
    public class IntersectionTests
    {
        private Intersection _intersection = new Intersection();

        [TestMethod]
        public void CheckLineSegmentsThrowArgumentExceptionSamePositions()
        {
            double[,] point1 = new double[,] { { 5, -3 }, { 5, -3 } };
            double[,] point2 = new double[,] { { 5, -3 }, { 5, -3 } };

            Func<double[]> find = () => _intersection.FindIntersection(point1, point2);

            find.Should().Throw<ArgumentException>()
                .And.Message.Should().Contain("Invalid x coordinates for run1 for point1.");
        }

        [TestMethod]
        public void CheckLineSegmentsThrowArgumentExceptionParallelLine()
        {
            double[,] point1 = new double[,] { { 5, -3 }, { -1, 8 } };
            double[,] point2 = new double[,] { { 5, -3 }, { -1, 8 } };

            Func<double[]> find = () => _intersection.FindIntersection(point1, point2);

            find.Should().Throw<ArgumentException>()
                .And.Message.Should().Contain("Same slope. Either parallel or same line.");
        }

        [TestMethod]
        public void CheckLineSegmentsNull()
        {
            double[,] point1 = new double[,] { { 5, -3 }, { -1, 8 } };
            double[,] point2 = new double[,] { { 4, -4 }, { 2, -7 } };

            double[] intersection = _intersection.FindIntersection(point1, point2);

            intersection.Should().BeNull();
        }

        [TestMethod]
        public void CheckLineSegmentsSuccess()
        {
            double[,] point1 = new double[,] { { 5, 5 }, { -3, 4 } };
            double[,] point2 = new double[,] { { -5, -7 }, { 5, 6 } };

            double[] intersection = _intersection.FindIntersection(point1, point2);

            Math.Round(intersection[0], 2).Should().Be(4.15);
            Math.Round(intersection[1], 2).Should().Be(4.89);
        }
    }
}
