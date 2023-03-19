namespace Inheritence;

/**
 * The Weapon class is the base class for all weapons in the game.
 */
public class Weapon
{
    private int _damage;
    private string _name;
    
    // Default constructor
    protected Weapon()
    {
        _damage = 10;
        _name = "Default";
    }
    
    // Constructor with parameters
    protected Weapon(int damage, string name)
    {
        this._damage = damage;
        this._name = name;
    }
    
    public void Attack()
    {
        Console.WriteLine("The weapon dealt " + this.GetDamage() + " damage.");
    }
    
    // Getters and setters
    protected int GetDamage()
    {
        return _damage;
    }
    
    public void SetDamage(int damage)
    {
        this._damage = damage;
    }
    
    public string GetName()
    {
        return _name;
    }
    
    public void SetName(string name)
    {
        this._name = name;
    }
}
