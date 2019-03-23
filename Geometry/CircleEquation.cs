namespace Geometry
{

    /// <summary>
    /// (x - a)^2 + (y - b)^2 = R^2
    /// </summary>
    public struct CircleEquation
    {

        public CircleEquation(double a, double b, double r)
        {
            A = a;
            B = b;
            R = r;
        }

        public double A { get; }

        public double B { get; }

        public double R { get; }

    }

}
