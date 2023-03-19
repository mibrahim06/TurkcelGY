namespace AbstractClass;

public class Square : Rectangle
{
    public Square()
    {
    }
    public Square(double side) : base(side, side)
    {
    }
    
    public double Side
    {
        get => Length;
        set => Length = value;
    }
    
    public override void PrintShape()
    {
        Console.WriteLine($"Square: Area = {Area()}, Perimeter = {Perimeter()}");
    }
}