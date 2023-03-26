namespace SingleResponsibilityPricinciple_SRP;

/**
 * This class is responsible for purchasing items from the shop.
 */
public class ItemShop
{
    private readonly Database _database;
    
    public ItemShop(Database database)
    {
        _database = database;
    }

    /**
     * @param playerId Id of the player
     * @param itemId Id of the item
     * @return true if the item was purchased, false otherwise
     */
    public bool PurchaseItem(int playerId, int itemId)
    {
        Item? item = _database.GetItem(itemId);
        int playerCoins = _database.GetPlayerCoins(playerId);
        
        if(item != null && playerCoins >= int.Parse(item.Price))
        {
            _database.AddItemToPlayer(playerId, itemId);
            _database.UpdatePlayerCoins(playerId, playerCoins - int.Parse(item.Price));
            return true;
        }

        return false;
    }
}