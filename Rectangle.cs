namespace MP_KT10_2025;

public class Rectangle : IClonable<Rectangle>
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(Rectangle other)
    {
        Width = other.Width;
        Height = other.Height;
    }

    public Rectangle Clone()
    {
        return new Rectangle(this);
    }

    public override string ToString()
    {
        return $"W={Width} H={Height}";
    }
}
