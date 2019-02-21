using System;
using System.Collections.Generic;
using System.Drawing;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            List<Point> l = new List<Point>();
            if (range <= 0)
                throw new ArgumentException();
            if (points == null)
                throw new ArgumentNullException();
            if (points.Length == 0)
                throw new ArgumentException();
            foreach (Point p in points)
                if (Math.Abs(p.X - point.X) <= range && Math.Abs(p.Y - point.Y) <= range)
                    l.Add(p);

            return l;
        }
    }
}