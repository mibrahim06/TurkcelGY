namespace Polymorphism;

// Lion is an Animal (inherits from Animal)
public class Lion : Animal
{
    // Override the Eat method
    public override void Eat()
    {
        Console.WriteLine("The lion ate a gazelle.");
    }
    
    // Override the MakeNoise method
    public override void MakeNoise()
    {
        Console.WriteLine("The lion roared.");
    }
    
    // Override the Move method
    public override void Move()
    {
        Console.WriteLine("The lion ran.");
    }
}
