namespace MP_KT10_2025;

public class Point : IClonable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(Point other)
    {
        X = other.X;
        Y = other.Y;
    }

    public Point Clone()
    {
        return new Point(this);
    }

    public override string ToString()
    {
        return $"X={X} Y={Y}";
    }
}
