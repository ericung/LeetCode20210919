using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Problem03
{
    public class Intersection
    {
        public double[] FindIntersection(double[,] point1, double[,] point2)
        {
            double rise1 = point1[1, 1] - point1[0, 1];
            double run1 = point1[1, 0] - point1[0, 0];
            double rise2 = point2[1, 1] - point2[0, 1];
            double run2 = point2[1, 0] - point2[0, 0];

            if ((run1 == 0)||(run2 == 0))
            {
                throw new ArgumentException("Invalid x coordinates for run1 for point1.");
            }

            double slope1 = rise1 / run1;
            double slope2 = rise2 / run2;

            if ((slope1 == slope2) || (slope1 == -1 * slope2))
            {
                throw new ArgumentException("Same slope. Either parallel or same line.");
            }

            double b1 = point1[0, 1] - slope1 * point1[0, 0];
            double b2 = point2[0, 1] - slope2 * point2[0, 0];

            double xIntersection = (b2 - b1) / (slope1 - slope2);
            double yIntersection = slope2 * xIntersection + b2;

            double[] intersection = new double[] { xIntersection, yIntersection };

            if ((IsBetween(intersection, point1)) && (IsBetween(intersection, point2)))
            {
                return intersection;
            }

            return null;
        }

        private Boolean IsBetween(double[] pointCheck, double[,] pointInterval)
        {
            double xMin = pointInterval[0,0] <= pointInterval[1,0] ? pointInterval[0,0] : pointInterval[1,0];
            double xMax = pointInterval[0,0] > pointInterval[1,0] ? pointInterval[0,0] : pointInterval[1,0];

            if ((pointCheck[0] >= xMin)&&(pointCheck[0] <= xMax))
            {
                return true;
            }

            return false;
        }
    }
}
