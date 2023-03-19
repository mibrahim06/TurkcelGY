namespace Metin2;

/**
 * @brief This class is base class for all weapons.
 */
public abstract class Weapon
{
    private int _damage;
    private int _price; 
    private string _name;
    // Default constructor
    protected Weapon()
    {
        this._damage = 10;
        this._price = 0;
        this._name = "Base Weapon";
    }
    
    // Constructor with parameters
    protected Weapon(int damage, int price, string name)
    {
        this._damage = damage;
        this._price = price;
        this._name = name;
    }
    
    // Abstract methods
    public abstract void Attack();
    
    // Getters and setters
    public int GetDamage()
    {
        return _damage;
    }
    
    public void SetDamage(int damage)
    {
        this._damage = damage;
    }
    
    public int GetPrice()
    {
        return _price;
    }
    
    public void SetPrice(int price)
    {
        this._price = price;
    }

    protected string GetName()
    {
        return _name;
    }
    
    public void SetName(string name)
    {
        this._name = name;
    }
}