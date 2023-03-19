namespace Inheritence;

// MageWeapon is a Weapon (inherits from Weapon)
public class MageWeapon : Weapon
{
    private int _manaCost;
    
    // Default constructor
    public MageWeapon()
    {
        _manaCost = 10;
    }
    
    // Constructor with parameters
    protected MageWeapon(int damage, string name, int manaCost) : base(damage, name)
    {
        this._manaCost = manaCost;
    }
    
    public new void Attack()
    {
        Console.WriteLine("The mage weapon dealt " + this.GetDamage() + " damage and cost " + _manaCost + " mana.");
    }

    public void CastSpell()
    {
        Console.WriteLine("The mage cast a spell using the weapon.");
    }
    
    // Getters and setters
    public int GetManaCost()
    {
        return _manaCost;
    }
    
    public void SetManaCost(int manaCost)
    {
        this._manaCost = manaCost;
    }
}
