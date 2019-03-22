using System.Collections.Generic;
using System;
using VectorAndPoint.ValTypes;
using System.Linq;

namespace Geometry
{
    public class Polygon : Shape
    {

        public IReadOnlyCollection<Point> Points { get; }

        public override double Perimeter => _getEdgesPointsBypass().Select(x => Point.GetRangeBetween(x.Item1, x.Item2)).Sum();

        public Polygon(params Point[] points)
        {
            if (points == null)
                throw new ArgumentNullException(nameof(points));
            if (points.Length < 3)
                throw new InvalidOperationException(nameof(points));

            Points = points;
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override PositionRelativeToArea GetPointPosition(Point point)
        {
            var eqs = new List<double>();
            foreach (var edge in _getEdgesPointsBypass())
            {
                var eq = (edge.Item1.X - point.X) * (edge.Item2.Y - edge.Item1.Y) - (edge.Item2.X - edge.Item1.X) * (edge.Item1.Y - point.Y);
                eqs.Add(eq);
            }

            if (eqs.Any(x => x == 0))
                return PositionRelativeToArea.OnEdge;

            if (eqs.Select(x => x > 0).Distinct().Count() == 1)
                return PositionRelativeToArea.Inside;

            return PositionRelativeToArea.Outside;
        }

        private IEnumerable<Tuple<Point, Point>> _getEdgesPointsBypass()
        {
            var pointsArr = Points.ToArray();
            var eqs = new List<double>();
            for (var i = 0; i < Points.Count; i++)
            {
                var currPoint = pointsArr[i];
                var nextPoint = (i == Points.Count - 1) ? pointsArr[0] : pointsArr[i + 1];

                yield return new Tuple<Point, Point>(currPoint, nextPoint);
            }
        }

    }
}