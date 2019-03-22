using VectorAndPoint;
using VectorAndPoint.ValTypes;

namespace Geometry
{
    public struct LineSegment : ILength
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public LineSegment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public Point A { get; }

        public Point B { get; }

        public double Length => Point.GetRangeBetween(A, B);

        public Point GetMiddlePoint()
        {
            var x = (A.X + B.X) / 2;
            var y = (A.Y + B.Y) / 2;

            return new Point(x, y);
        }

        public static explicit operator Vector(LineSegment line) => new Vector(line.B.X - line.A.X, line.B.Y - line.A.Y);

    }
}