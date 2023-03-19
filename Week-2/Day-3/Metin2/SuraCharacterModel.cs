namespace Metin2;

public class SuraCharacterModel : AbstractCharacterModel
{
    private int _attackRange;
    
    // Default constructor
    public SuraCharacterModel()
    {
        this._attackRange = 5;
    }
    
    // Constructor with parameters
    public SuraCharacterModel(string name, int level, int experience, int health, int mana, int attackRange) : base(name, level, experience, health, mana)
    {
        this._attackRange = attackRange;
    }
    
    // Override methods
    public override void Attack()
    {
        Console.WriteLine("The sura attacked.");
    }
    
    public override void Defend()
    {
        Console.WriteLine("The sura defended.");
    }
    
    public override void Move()
    {
        Console.WriteLine("The sura moved.");
    }
    
    public override void Die()
    {
        Console.WriteLine("The sura died.");
    }
    // Skills and abilities of the sura
    public void Charge()
    {
        Console.WriteLine("The sura charged.");
    }
    
    public void Block()
    {
        Console.WriteLine("The sura blocked.");
    }
    
    // Getters and setters
    public int GetAttackRange()
    {
        return _attackRange;
    }
    
    public void SetAttackRange(int attackRange)
    {
        this._attackRange = attackRange;
    }
}