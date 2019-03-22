using System;
using Geometry;
using Geometry.Shapes;
using VectorAndPoint.ValTypes;
using Xunit;

namespace Tests
{

    public class LineSegmentTest
    {

        [Fact]
        public void CastToLineTest()
        {
            var a = new Point(0, 2);
            var b = new Point(1, 3);

            var lineSegment = new LineSegment(a, b);
            var line = lineSegment.Line;

            Assert.Equal(1, line.Y);
            Assert.Equal(-1, line.X);
            Assert.Equal(-2, line.C);
            Assert.Equal(new Line(1, 2), line);
        }

    }
}
