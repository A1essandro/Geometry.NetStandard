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
        public void ViaEquationTest()
        {
            var equation = new CircleEquation(1, -1, 2);

            var circle = new Circle(equation);

            Assert.Equal(2, circle.Radius);
            Assert.Equal(1, circle.Center.X);
            Assert.Equal(-1, circle.Center.Y);
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
