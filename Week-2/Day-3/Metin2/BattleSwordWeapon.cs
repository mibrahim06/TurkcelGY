namespace Metin2;

public class BattleSwordWeapon : Weapon
{
  
    public BattleSwordWeapon() : base(150, 1000, "Battle Sword")
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"The player attacked with the {this.GetName()} weapon. Damage: {this.GetDamage()}");
    }
}