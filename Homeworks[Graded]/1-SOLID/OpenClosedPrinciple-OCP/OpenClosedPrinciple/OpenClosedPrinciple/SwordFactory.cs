namespace OpenClosedPrinciple;

public enum SwordType
{
    SimpleSword,
    LongSword,
    GreatSword,
    SilverSword,
    FullMoonSword
}

public class SwordFactory : IItemFactory
{
    public Item CreateItem()
    {
        return new Item(1, "Simple sword", 100);
    }

    public Item CreateItem(SwordType swordType)
    {
        switch (swordType)
        {
            case SwordType.GreatSword:
                return new Item(1, "Great sword", 150);
            
            case SwordType.LongSword:
                return  new Item(1, "Long sword", 250);
            
            case SwordType.SimpleSword:
                return new Item(1, "Simple sword", 350);
            
            case SwordType.SilverSword:
                return new Item(1, "Silver sword", 450);
            
            case SwordType.FullMoonSword:
                return new Item(1, "Full moon sword", 650);

            default:
                return new Item(1, "Simple sword", 100);
        }
    }
    
}
