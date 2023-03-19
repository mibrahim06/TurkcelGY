using ClassVsObject;

// Create a Ford Mustang  
Car fordMustang = new Car();
fordMustang.Brand = "Ford";
fordMustang.Model = "Mustang";
fordMustang.Year = 1969;
fordMustang.Color = "Red";
fordMustang.MaxSpeed = 200;
fordMustang.Price = 100000;

// Print the properties of the car
fordMustang.PrintCarProperties();

// Start the car
fordMustang.Start();

// Accelerate the car
fordMustang.Accelerate(50);

// Print the current speed of the car
Console.WriteLine($"Current speed: {fordMustang.CurrentSpeed}");

// Stop the car
fordMustang.Stop();

// Create a Tesla Model S with object initializer
var teslaModelS = new Car()
{
    Brand = "Tesla",
    Model = "Model S",
    Year = 2019,
    Color = "Black",
    MaxSpeed = 250,
    Price = 1000000
};

// Print the properties of the car
teslaModelS.PrintCarProperties();

// Start the car
teslaModelS.Start();

// Accelerate the car
teslaModelS.Accelerate(190);

// Print the current speed of the car
Console.WriteLine($"Current speed: {teslaModelS.CurrentSpeed}");

// Stop the car
teslaModelS.Stop();