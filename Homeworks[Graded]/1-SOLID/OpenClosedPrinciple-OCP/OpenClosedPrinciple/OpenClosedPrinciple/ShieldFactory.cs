namespace OpenClosedPrinciple;

public enum  ShieldType
{
    BattleShield,
    PentagonShield,
    BlackRoundShield,
    DragonScaleShield
}

public class ShieldFactory : IItemFactory
{
    public Item CreateItem()
    {
        return new Item(1, "Simple shield", 100);
    }

    public Item CreateItem(ShieldType shieldType)
    {
        switch (shieldType)
        {
            case ShieldType.BattleShield:
                return new Item(1, "Battle shield", 247);
            
            case ShieldType.PentagonShield:
                return  new Item(1, "Pentagon shield", 743);
            
            case ShieldType.BlackRoundShield:
                return new Item(1, "Black round shield", 1893);
            
            case ShieldType.DragonScaleShield:
                return new Item(1, "Dragon scale shield", 5489);
            
            default:
                return new Item(1, "Simple shield", 7894);
        }
    }

}
