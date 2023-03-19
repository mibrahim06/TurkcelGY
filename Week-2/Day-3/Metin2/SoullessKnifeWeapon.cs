namespace Metin2;

public class SoullessKnifeWeapon : Weapon
{
    public SoullessKnifeWeapon() : base(350, 5000, "Soulless Knife")
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"The player attacked with the {this.GetName()} weapon. Damage: {this.GetDamage()}");
    }
}
