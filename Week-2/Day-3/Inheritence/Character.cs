namespace Inheritence;

/**
 * The Character class is the base class for all characters in the game.
 */
public class Character
{
    private string _name;
    private int _health;
    private int _level;
    private Weapon _weapon;
    
    // Constructor with parameters
    protected Character(string name, int health, int level, Weapon weapon)
    {
        this._name = name;
        this._health = health;
        this._level = level;
        this._weapon = weapon;
    }

    protected void Attack()
    {
        Console.WriteLine("The character attacked with a basic attack.");
    }
    
    // Getters and setters
    public string GetName()
    {
        return _name;
    }
    
    public void SetName(string name)
    {
        this._name = name;
    }
    
    public int GetHealth()
    {
        return _health;
    }
    
    public void SetHealth(int health)
    {
        this._health = health;
    }
    
    public int GetLevel()
    {
        return _level;
    }
    
    public void SetLevel(int level)
    {
        this._level = level;
    }

    protected Weapon GetWeapon()
    {
        return _weapon;
    }
    
    public void SetWeapon(Weapon weapon)
    {
        this._weapon = weapon;
    }
    
    // Print the character's stats
    public void PrintStats()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Health: " + _health);
        Console.WriteLine("Level: " + _level);
        Console.WriteLine("Weapon: " + _weapon.GetName());
    }
}
