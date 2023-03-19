using Polymorphism;

// Create a new animal
Animal animal = new Animal();

// Create a new lion and make the animal a lion
Animal lion = new Lion();
animal.SetAnimal(lion);
animal.Eat();
animal.MakeNoise();
animal.Move();

Console.WriteLine(new string('-', 50));

// Create a new bird and make the animal a bird
Animal bird = new Bird();
animal.SetAnimal(bird);
animal.Eat();
animal.MakeNoise();
animal.Move();

Console.WriteLine(new string('-', 50));

// Create a new fish and make the animal a fish
Animal fish = new Fish();
animal.SetAnimal(fish);
animal.Eat();
animal.MakeNoise();
animal.Move();
