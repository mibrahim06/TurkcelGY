namespace Polymorphism;

public class Bird : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The bird ate a insect.");
    }
    
    public override void MakeNoise()
    {
        Console.WriteLine("The bird chirped.");
    }
    
    public override void Move()
    {
        Console.WriteLine("The bird flew.");
    }
}