using System;
using VectorAndPoint.ValTypes;

namespace Geometry
{
    public class Square : Quadrangle
    {
        public Square(Point a, Point b, Point c, Point d)
            : base(a, b, c, d)
        {
        }

        public static bool IsSquare(Point a, Point b, Point c, Point d)
        {
            var rangeAC = Point.GetRangeBetween(a, c);
            var rangeBD = Point.GetRangeBetween(b, d);
            if (rangeAC != rangeBD)
                return false;

            var rangeAB = Point.GetRangeBetween(a, b);
            var rangeAD = Point.GetRangeBetween(a, d);
            var rangeBC = Point.GetRangeBetween(b, c);
            var rangeCD = Point.GetRangeBetween(c, d);
            if (rangeAB != rangeAD || rangeAD != rangeBC || rangeBC != rangeCD || rangeCD != rangeAB)
                return false;

            return rangeAC == Math.Sqrt(Math.Pow(rangeAB, 2) + Math.Pow(rangeBC, 2)) && rangeBD == Math.Sqrt(Math.Pow(rangeBC, 2) + Math.Pow(rangeCD, 2));
        }

    }
}