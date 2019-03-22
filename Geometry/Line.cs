using System;

namespace Geometry
{
    public struct Line : IEquatable<Line>
    {

        public Line(double y, double x, double c)
        {
            Y = y;
            X = x;
            C = c;
        }

        public Line(double x, double c)
            : this(-1, x, c)
        {
        }

        public double Y { get; }

        public double X { get; }

        public double C { get; }

        public bool IsParallelWith(Line other) => X / Y == other.X / other.Y;

        public Line Revert() => new Line(-Y, -X, -C);

        public override int GetHashCode() => (X / Y).GetHashCode() ^ C.GetHashCode();

        public bool Equals(Line other) => GetHashCode() == other.GetHashCode() || GetHashCode() == other.Revert().GetHashCode();

    }
}