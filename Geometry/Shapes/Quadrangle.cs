using System;
using VectorAndPoint.ValTypes;

namespace Geometry.Shapes
{
    public class Quadrangle : Polygon
    {

        public Quadrangle(Point a, Point b, Point c, Point d)
            : base(a, b, c, d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Point A { get; }

        public Point B { get; }

        public Point C { get; }

        public Point D { get; }

        public override double GetArea()
        {
            var ab = Point.GetRangeBetween(A, B);
            var ad = Point.GetRangeBetween(A, D);
            var bc = Point.GetRangeBetween(B, C);
            var cd = Point.GetRangeBetween(C, D);
            var p = (ab + ad + bc + cd) / 2;

            return Math.Sqrt(p * (p - ab) * (p - ad) * (p - bc) * (p - cd));
        }

        public override PositionRelativeToArea GetPointPosition(Point point)
        {
            throw new NotImplementedException();
        }
    }
}