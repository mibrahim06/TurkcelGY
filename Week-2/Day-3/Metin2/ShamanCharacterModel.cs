namespace Metin2;

public class ShamanCharacterModel : AbstractCharacterModel
{
    private int _manaRegeneration;

    // Default constructor
    public ShamanCharacterModel() : base()
    {
        this._manaRegeneration = 0;
    }

    // Constructor with parameters
    public ShamanCharacterModel(string name, int level, int experience, int health, int mana, int manaRegeneration) : base(name, level, experience, health, mana)
    {
        this._manaRegeneration = manaRegeneration;
    }

    // Override methods
    public override void Attack()
    {
        Console.WriteLine("Shaman attacks!");
    }

    public override void Defend()
    {
        Console.WriteLine("Shaman defends!");
    }

    public override void Move()
    {
        Console.WriteLine("Shaman moves!");
    }

    public override void Die()
    {
        Console.WriteLine("Shaman dies!");
    }

    // Getters and setters
    public int GetManaRegeneration()
    {
        return _manaRegeneration;
    }

    public void SetManaRegeneration(int manaRegeneration)
    {
        this._manaRegeneration = manaRegeneration;
    }
    
}