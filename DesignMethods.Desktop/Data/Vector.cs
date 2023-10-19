namespace DesignMethods.Desktop.Data;

public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y) => (X, Y) = (x, y);

    public double GetLength()
    {
        if (X == 0 && Y == 0) return 0;
        return Math.Round(Math.Sqrt(X * X + Y * Y), 3);
    }

    public Vector Add(Vector v) => new Vector(X + v.X, Y + v.Y);

    public Vector Subtract(Vector v) => new Vector(X - v.X, Y - v.Y);

    public override string ToString() => $"(X = {X}, Y = {Y})";
}
