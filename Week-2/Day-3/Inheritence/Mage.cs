namespace Inheritence;

// Mage is a Character (inherits from Character)
public class Mage : Character
{
    private int _mana;
    
    // Constructor with parameters
    public Mage (string name, int health, int level, int mana, Weapon weapon) : 
        base(name, health, level, weapon)
    {
        this._mana = mana;
    }

    public new void Attack()
    {
        if(GetWeapon() is MageWeapon)
        {
            ((MageWeapon)this.GetWeapon()).Attack();
        }
        else
        {
            Console.WriteLine("The mage attacked with a basic attack.");
        }
    }
    
    public void CastSpell()
    {
        Console.WriteLine("The mage cast a spell.");
        _mana -= 10;
    }
    
    public int GetMana()
    {
        return _mana;
    }
    
    public void SetMana(int mana)
    {
        _mana = mana;
    }
}
