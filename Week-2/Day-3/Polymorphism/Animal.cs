namespace Polymorphism;

/**
 * This is the base class for all animals to show polymorphism.
 */
public class Animal
{
    private Animal animal;
    
    public virtual void Eat()
    {
        animal.Eat();
    }
    
    public virtual void MakeNoise()
    {
        animal.MakeNoise();
    }

    public virtual void Move()
    {
        animal.Move();
    }
    
    public void SetAnimal(Animal animal)
    {
        this.animal = animal;
    }
    
    public Animal GetAnimal()
    {
        return animal;
    }
}
