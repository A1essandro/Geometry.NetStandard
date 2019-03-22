using System;
using VectorAndPoint;
using VectorAndPoint.ValTypes;

namespace Geometry
{
    public class Circle : Shape, ILength
    {

        public Point Center { get; }

        public double Radius { get; }

        public double Length => 2 * Math.PI * Radius;

        public override double Perimeter => Length;

        public Circle(Point center, double radius)
        {
            Radius = radius;
            Center = center;
        }

        public override double GetArea() => Math.PI * Radius * Radius;

        public override PositionRelativeToArea GetPointPosition(Point point)
        {
            var toCenter = Point.GetRangeBetween(Center, point);
            if (toCenter < Radius)
                return PositionRelativeToArea.Inside;
            if (toCenter > Radius)
                return PositionRelativeToArea.Outside;
            return PositionRelativeToArea.OnEdge;
        }

    }
}