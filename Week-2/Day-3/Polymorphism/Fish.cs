namespace Polymorphism;

public class Fish : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The fish ate a worm.");
    }
    
    public override void MakeNoise()
    {
        Console.WriteLine("The fish made a noise.");
    }
    
    public override void Move()
    {
        Console.WriteLine("The fish swam.");
    }
}