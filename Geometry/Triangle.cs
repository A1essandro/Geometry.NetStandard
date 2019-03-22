using System;
using System.Collections.Generic;
using VectorAndPoint.ValTypes;

namespace Geometry
{
    public class Triangle : Polygon
    {

        public Triangle(Point a, Point b, Point c)
            : base(a, b, c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Point A { get; }

        public Point B { get; }

        public Point C { get; }

        public override double GetArea()
        {
            var ab = Point.GetRangeBetween(A, B);
            var ac = Point.GetRangeBetween(A, C);
            var bc = Point.GetRangeBetween(B, C);
            var p = (ab + ac + bc) / 2;

            return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
        }

    }
}