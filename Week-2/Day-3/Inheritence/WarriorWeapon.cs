namespace Inheritence;

// WarriorWeapon is a Weapon (inherits from Weapon)
public class WarriorWeapon : Weapon
{
    private readonly int _durability;
    
    // Default constructor
    public WarriorWeapon()
    {
        _durability = 100;
    }
    
    // Constructor with parameters
    protected WarriorWeapon(int damage, string name, int durability) : base(damage, name)
    {
        this._durability = durability;
    }
    
    public new void Attack()
    {
        Console.WriteLine("The warrior weapon dealt " + this.GetDamage() + " damage and has " + _durability + " durability.");
    }
}
