namespace Metin2;

public abstract class AbstractCharacterModel
{
    private string _name;
    private int _level;
    private int _experience;
    private int _health;
    private int _mana;
    private Weapon _weapon;
    
    // Default constructor
    protected AbstractCharacterModel()
    {
        this._name = "name";
        this._level = 1;
        this._experience = 0;
        this._health = 100;
        this._mana = 100;
        this._weapon = null;
    }
    
    // Constructor with parameters
    protected AbstractCharacterModel(string name, int level, int experience, int health, int mana)
    {
        this._name = name;
        this._level = level;
        this._experience = experience;
        this._health = health;
        this._mana = mana;
    }
    
    // Abstract methods
    public abstract void Attack();
    public abstract void Defend();
    public abstract void Move();
    public abstract void Die();
    
    // Getters and setters
    public string GetName()
    {
        return _name;
    }
    
    public void SetName(string name)
    {
        this._name = name;
    }
    
    public int GetLevel()
    {
        return _level;
    }
    
    public void SetLevel(int level)
    {
        this._level = level;
    }
    
    public int GetExperience()
    {
        return _experience;
    }
    
    public void SetExperience(int experience)
    {
        this._experience = experience;
    }
    
    public int GetHealth()
    {
        return _health;
    }
    
    public void SetHealth(int health)
    {
        this._health = health;
    }
    
    public int GetMana()
    {
        return _mana;
    }
    
    public void SetMana(int mana)
    {
        this._mana = mana;
    }

    protected Weapon GetWeapon()
    {
        return _weapon;
    }
    
    public void SetWeapon(Weapon weapon)
    {
        this._weapon = weapon;
    }
}