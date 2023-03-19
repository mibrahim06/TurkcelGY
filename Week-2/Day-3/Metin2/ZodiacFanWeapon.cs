namespace Metin2;

public class ZodiacFanWeapon : Weapon
{
    public ZodiacFanWeapon() : base(690, 10050, "Zodiac Fan")
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"The player attacked with the {this.GetName()} weapon. Damage: {this.GetDamage()}");
    }
}