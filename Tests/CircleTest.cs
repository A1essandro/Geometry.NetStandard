using System;
using Geometry;
using Geometry.Shapes;
using VectorAndPoint.ValTypes;
using Xunit;

namespace Tests
{

    public class CircleTest
    {

        [Fact]
        public void AreaTest()
        {
            var center = new Point(0, 0);
            var radius = 1;

            var circle = new Circle(center, radius);

            Assert.Equal(Math.Round(Math.PI, 5), Math.Round(circle.GetArea(), 5));
        }

        [Fact]
        public void PointPositionTest()
        {
            var center = new Point(0, 0);
            var radius = 1;

            var circle = new Circle(center, radius);

            var inside = new Point(0.5, 0.5);
            var outside = new Point(1, 1);
            var onEdge = new Point(1, 0);

            Assert.Equal(PositionRelativeToArea.Inside, circle.GetPointPosition(inside));
            Assert.Equal(PositionRelativeToArea.Outside, circle.GetPointPosition(outside));
            Assert.Equal(PositionRelativeToArea.OnEdge, circle.GetPointPosition(onEdge));
        }

    }
}
