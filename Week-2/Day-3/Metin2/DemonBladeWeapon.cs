namespace Metin2;

public class DemonBladeWeapon : Weapon
{
    public DemonBladeWeapon() : base(200, 2000, "Demon Blade")
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"The player attacked with the {this.GetName()} weapon. Damage: {this.GetDamage()}");
    }
}