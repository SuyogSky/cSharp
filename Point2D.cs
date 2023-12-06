using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public struct Point2D
    {
        public float X { get; }
        public float Y { get; }

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class DistanceCalculator
    {
        public void CalculateDistance(Point2D point1, Point2D point2)
        {
            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            Console.WriteLine($"Distance between pointA and pointB: {distance}");
        }
    }
}
