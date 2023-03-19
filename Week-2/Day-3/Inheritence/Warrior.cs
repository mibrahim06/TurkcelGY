namespace Inheritence;

// Warrior is a Character (inherits from Character)
public class Warrior : Character
{
    private int _rage;
    
    // Constructor with parameters
    public Warrior(string name, int health, int level, int rage, Weapon weapon) : base(name, health, level, weapon)
    {
        this._rage = rage;
    }
    
    // Getters and setters
    public int GetRage()
    {
        return _rage;
    }
    
    public void SetRage(int rage)
    {
        this._rage = rage;
    }
    
    // Attack method
    public new void Attack()
    {
        if(this.GetWeapon() is WarriorWeapon)
        {
            ((WarriorWeapon)this.GetWeapon()).Attack();
        }
        else
        {
            Console.WriteLine("The warrior attacked with a basic attack.");
        }
    }
    
    public void Charge()
    {
        Console.WriteLine("The warrior charged.");
        _rage -= 10;
    }
}
