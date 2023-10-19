Vector A = new(1, 2);
Vector B = new(3, 4);

Vector C = A.Add(B);

Console.WriteLine(C);

Vector D = A.Subtract(B);

Console.WriteLine(D);

Console.WriteLine(A.GetLength());


public sealed class Vector
{
    public string Name { get; init; }
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y) => (X, Y) = (x, y);

    public double GetLength() => Math.Round(Math.Sqrt(X * X + Y * Y), 3);

    public Vector Add(Vector v) => new(X + v.X, Y + v.Y);

    public Vector Subtract(Vector v) => new(X - v.X, Y - v.Y);

    public override string ToString() => $"{Name}({X}, {Y})";
}