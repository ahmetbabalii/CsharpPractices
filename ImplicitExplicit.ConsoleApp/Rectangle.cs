namespace ImplicitExplicit.ConsoleApp;

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public static implicit operator double(Rectangle rectangle)
    {
        return Math.Sqrt(Math.Pow(rectangle.Width, 2) + Math.Pow(rectangle.Height, 2));
    }
}

