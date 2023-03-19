namespace Inheritence;

// AxeOfDestruction is a WarriorWeapon (inherits from WarriorWeapon)
public class AxeOfDestruction : WarriorWeapon
{
    public AxeOfDestruction() : base(150, "Axe of Destruction", 120)
    {
    }

    public void Cleave()
    {
        Console.WriteLine("The warrior cleaved with the axe of destruction.");
    }
}
