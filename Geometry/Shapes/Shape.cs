using VectorAndPoint.ValTypes;

namespace Geometry.Shapes
{
    public abstract class Shape : IArea
    {

        public abstract double Perimeter { get; }

        public abstract double GetArea();

        public abstract PositionRelativeToArea GetPointPosition(Point point);

    }
}