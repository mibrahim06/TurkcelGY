namespace OpenClosedPrinciple;

    

public class Program
{
    public static void Main(string[] args)
    {
        // To create a sword, we need to use the SwordFactory.
        var swordFactory = new SwordFactory();
        
        // To create an armor, we need to use the ArmorFactory.
        var armorFactory = new ArmorFactory();
        
        // To create a shield, we need to use the ShieldFactory.
        var shieldFactory = new ShieldFactory();
        
        // Crate a FullMoonSword
        var fullMoonSword = swordFactory.CreateItem(SwordType.FullMoonSword);
        Console.WriteLine($"Created a {fullMoonSword.Name}, price: {fullMoonSword.Price}");
        
        // Create a GreatSword
        var greatSword = swordFactory.CreateItem(SwordType.GreatSword);
        Console.WriteLine($"Created a {greatSword.Name}, price: {greatSword.Price}");
        
        // Create a DragonPlateArmor
        var dragonPlateArmor = armorFactory.CreateItem(ArmorType.DragonPlateArmor);
        Console.WriteLine($"Created a {dragonPlateArmor.Name}, price: {dragonPlateArmor.Price}");
        
        // Create a LionPlateArmor
        var lionPlateArmor = armorFactory.CreateItem(ArmorType.LionPlateArmor);
        Console.WriteLine($"Created a {lionPlateArmor.Name}, price: {lionPlateArmor.Price}");
        
        // Create a DragonScaleShield
        var dragonScaleShield = shieldFactory.CreateItem(ShieldType.DragonScaleShield);
        Console.WriteLine($"Created a {dragonScaleShield.Name}, price: {dragonScaleShield.Price}");
        
        // Create a PentagonShield
        var pentagonShield = shieldFactory.CreateItem(ShieldType.PentagonShield);
        Console.WriteLine($"Created a {pentagonShield.Name}, price: {pentagonShield.Price}");
     
    }
}
