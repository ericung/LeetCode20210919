using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Problem01
{
    public class Intersection
    {
        // point[,1] = y, point[,0] = x 
        public int[,] FindIntersection(int[,] point1, int[,] point2)
        {
            double rise1 = point1[1, 1] - point1[0, 1];
            double run1 = point1[1, 0] - point1[0, 0];
            double rise2 = point2[1, 1] - point2[0, 1];
            double run2 = point2[1, 0] - point2[0, 1];

            if (run1 == 0)
            {
                throw new ArgumentException("Invalid x coordinates for run1 for point1");
            }

            if (run2 == 0)
            {
                throw new ArgumentException("Invalid x coordinates for run2 for point2");
            }

            double slope1 = rise1 / run1;
            double slope2 = rise2 / run2;

            if ((slope1 == slope2) || (slope1 == -1 * slope2))
            {
                throw new ArgumentException("Same slope. Either parallel or ssame line.");
            }

            double b1 = point1[0, 1] - slope1 * point1[0, 0];
            double b2 = point2[0, 1] - slope2 * point2[0, 0];

            double xIntersection = (b2 - b1) / (slope1 - slope2);
            double yIntersection = slope2 * xIntersection + b2;

            if ((xIntersection > point1[0,0])&&(xIntersection < point1[1,0]))

            return new int[2, 2];
        }

        private Boolean IsBetween(int[,] pointCheck, int[,] pointInterval)
        {

        }
    }
}
