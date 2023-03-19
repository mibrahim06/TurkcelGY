namespace ClassVsObject;

/**
 * This class represents a car
 * Functions:
 * - PrintCarProperties: Prints the properties of the car
 * - Start: Starts the car
 * - Accelerate: Accelerates the car
 * - Stop: Stops the car
 */
public class Car
{
    public string Brand;
    public string Model;
    public int Year;
    public string Color;
    public int MaxSpeed;
    public int Price;
    public int CurrentSpeed;
    
    /**
     * This method prints the properties of the car
     */
    public void PrintCarProperties()
    {
        Console.WriteLine("Brand: " + Brand);
        System.Console.WriteLine("Model: " + Model);
        System.Console.WriteLine("Year: " + Year);
        System.Console.WriteLine("Color: " + Color);
        System.Console.WriteLine("Max Speed: " + MaxSpeed);
    }
    
    /**
     * This method starts the car
     */
    public void Start()
    {
        Console.WriteLine($"Now starting {Brand} {Model}");
        CurrentSpeed = 1;
    }
    
    /**
     * This method accelerates the car
     * @param speed: The speed to accelerate with
     */
    public void Accelerate(int speed)
    {
        if (CurrentSpeed + speed > MaxSpeed)
        {
            CurrentSpeed = MaxSpeed;
        }
        else
        {
            CurrentSpeed += speed;
        }
    }
    
    /**
     * This method stops the car
     */
    public void Stop()
    {
        Console.WriteLine($"Now stopping {Brand} {Model}");
        CurrentSpeed = 0;
    }
}