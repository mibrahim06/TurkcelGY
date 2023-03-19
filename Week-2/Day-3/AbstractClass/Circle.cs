namespace AbstractClass;

public class Circle : Shape
{
    private double _radius = 1;
    public double Radius
    {
        get => _radius;
        set => _radius = value;
    }
    
    public Circle()
    {
    }
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
    
    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
    
    public override void PrintShape()
    {
        Console.WriteLine($"Circle: Area = {Area()}, Perimeter = {Perimeter()}");
    }
    
}