namespace OpenClosedPrinciple;

public enum ArmorType
{
    MonkPlateArmor,
    IronPlateArmor,
    TigerPlateArmor,
    LionPlateArmor,
    DragonPlateArmor,
}

public class ArmorFactory : IItemFactory
{
    public Item CreateItem()
    {
        return new Item(1, "Simple armor", 100);
    }
    
    public Item CreateItem(ArmorType armorType)
    {
        switch (armorType)
        {
            case ArmorType.MonkPlateArmor:
                return new Item(1, "Monk plate armor", 178);
            
            case ArmorType.IronPlateArmor:
                return  new Item(1, "Iron plate armor", 278);
            
            case ArmorType.TigerPlateArmor:
                return new Item(1, "Tiger plate armor", 873);
            
            case ArmorType.LionPlateArmor:
                return new Item(1, "Lion plate armor", 1784);
            
            case ArmorType.DragonPlateArmor:
                return new Item(1, "Dragon plate armor", 3784);

            default:
                return new Item(1, "Simple armor", 100);
        }
    }
}
