namespace Inheritence;

// StaffOfFrost is a MageWeapon (inherits from MageWeapon)
public class StaffOfFrost : MageWeapon
{
    public StaffOfFrost() : base(150, "Staff of Frost", 50)
    {
    }
    
    public void Freeze()
    {
        Console.WriteLine("The mage froze the enemy with the staff of frost.");
    }
}
