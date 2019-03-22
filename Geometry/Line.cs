namespace Geometry
{
    public struct Line
    {

        public Line(double x, double c)
        {
            X = x;
            C = c;
        }

        public double X { get; }

        public double C { get; }

        public bool IsParallelWith(Line other) => other.C == C;

    }
}