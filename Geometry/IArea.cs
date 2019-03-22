using VectorAndPoint.ValTypes;

namespace Geometry
{
    public interface IArea
    {

        double Perimeter { get; }

        double GetArea();

        PositionRelativeToArea GetPointPosition(Point point);

    }
}