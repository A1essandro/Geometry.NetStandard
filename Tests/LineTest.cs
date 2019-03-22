using System;
using Geometry;
using Geometry.Shapes;
using VectorAndPoint.ValTypes;
using Xunit;

namespace Tests
{

    public class LineTest
    {

        [Fact]
        public void ParallelTest()
        {
            var line1 = new Line(1, 1, 2);
            var line2 = new Line(2, 2, 2);
            var line3 = new Line(1, 0, 2);

            Assert.True(line1.IsParallelWith(line1));
            Assert.True(line1.IsParallelWith(line2));
            Assert.False(line1.IsParallelWith(line3));
        }

    }
}
