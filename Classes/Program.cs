using System.IO.Compression;

var rectangle1 = new Rectangle(2, 10);

Console.WriteLine("Width is: " + rectangle1.Width);
Console.WriteLine("Height is: " + rectangle1.Height);
Console.WriteLine("Area is: " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is: " + rectangle1.CalculateCircumference());

var rectangle2 = new Rectangle(10, 10);

Console.WriteLine("Width is: " + rectangle2.Width);
Console.WriteLine("Height is: " + rectangle2.Height);
Console.WriteLine("Area is: " + rectangle2.CalculateArea());
Console.WriteLine("Circumference is: " + rectangle2.CalculateCircumference());

class Rectangle
{
    public int Width;
    public int Height;

    // The following is an constructure 
    // it runs when we initialize an object using this class as a blueprint.
    // The constructure should have same name as the class.
    // and also no need to declare the return type for the constructor.

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // following is simply an method

    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}