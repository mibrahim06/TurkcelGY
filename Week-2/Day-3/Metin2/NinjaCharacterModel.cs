namespace Metin2;

public class NinjaCharacterModel : AbstractCharacterModel
{
    private int _attackRange;
    
    // Default constructor
    public NinjaCharacterModel()
    {
        this._attackRange = 10;
    }
    
    // Constructor with parameters
    public NinjaCharacterModel(string name, int level, int experience, int health, int mana, int attackRange) : base(name, level, experience, health, mana)
    {
        this._attackRange = attackRange;
    }
    
    // Override methods
    public override void Attack()
    {
        Console.WriteLine("The ninja attacked.");
    }
    
    public override void Defend()
    {
        Console.WriteLine("The ninja defended.");
    }
    
    public override void Move()
    {
        Console.WriteLine("The ninja moved.");
    }
    
    public override void Die()
    {
        Console.WriteLine("The ninja died.");
    }
    // Skills and abilities of the ninja
    public void Charge()
    {
        Console.WriteLine("The ninja charged.");
    }
    
    public void Block()
    {
        Console.WriteLine("The ninja blocked.");
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