namespace Metin2;

public class WarriorCharacterModel : AbstractCharacterModel
{
    private int _attackRange;
    
    // Default constructor
    public WarriorCharacterModel()
    {
        this._attackRange = 1;
    }
    
    // Constructor with parameters
    public WarriorCharacterModel(string name, int level, int experience, int health, int mana, int attackRange) : base(name, level, experience, health, mana)
    {
        this._attackRange = attackRange;
    }
    
    // Override methods
    public override void Attack()
    {
        Console.WriteLine("The warrior attacked.");
    }
    
    public override void Defend()
    {
        Console.WriteLine("The warrior defended.");
    }
    
    public override void Move()
    {
        Console.WriteLine("The warrior moved.");
    }
    
    public override void Die()
    {
        Console.WriteLine("The warrior died.");
    }
    // Skills and abilities of the warrior
    public void Charge()
    {
        Console.WriteLine("The warrior charged.");
    }
    
    public void Block()
    {
        Console.WriteLine("The warrior blocked.");
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