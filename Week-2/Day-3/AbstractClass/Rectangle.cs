namespace AbstractClass;

public class Rectangle : Shape
{
    private double _length = 1;
    private double _width = 1;
    
    public double Length
    {
        get => _length;
        set => _length = value;
    }
    
    public double Width
    {
        get => _width;
        set => _width = value;
    }
    
    public Rectangle()
    {
    }
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    
    public override double Area()
    {
        return Length * Width;
    }
    
    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }
    
    public override void PrintShape()
    {
        Console.WriteLine($"Rectangle: Area = {Area()}, Perimeter = {Perimeter()}");
    }
    
}