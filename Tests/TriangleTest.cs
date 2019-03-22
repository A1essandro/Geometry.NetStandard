using System;
using Geometry;
using Geometry.Shapes;
using VectorAndPoint.ValTypes;
using Xunit;

namespace Tests
{

    public class TriangleTest
    {

        [Fact]
        public void AreaTest()
        {
            var a = new Point(0, 0);
            var b = new Point(0, 1);
            var c = new Point(1, 0);

            var triangle = new Triangle(a, b, c);

            Assert.Equal(0.5, Math.Round(triangle.GetArea(), 5));
        }

        [Fact]
        public void PointPositionTest()
        {
            var a = new Point(0, 0);
            var b = new Point(0, 1);
            var c = new Point(1, 0);

            var triangle = new Triangle(a, b, c);

            var inside = new Point(0.1, 0.1);
            var outside = new Point(1, 1);
            var onEdge = new Point(0.5, 0);

            Assert.Equal(PositionRelativeToArea.Inside, triangle.GetPointPosition(inside));
            Assert.Equal(PositionRelativeToArea.Outside, triangle.GetPointPosition(outside));
            Assert.Equal(PositionRelativeToArea.OnEdge, triangle.GetPointPosition(onEdge));
        }

    }
}
