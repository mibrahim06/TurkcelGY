namespace SingleResponsibilityPricinciple_SRP;

/**
 * This class represents the database of the game.
 */
public class Database
{
    private readonly Dictionary<int, decimal> _playerCoins;
    public readonly Dictionary<int, List<int>> PlayerItems;
    private readonly Dictionary<int, Item?> _items;
    
    /**
     * @brief Constructor for the Database class
     * @details This constructor creates sample data for the database.
     */
    public Database()
    {
        _playerCoins = new Dictionary<int, decimal>();
        PlayerItems = new Dictionary<int, List<int>>();
        _items = new Dictionary<int, Item?>();

        // Creating sample data
        InitializeData();
    }

    /**
     * @brief Initializes the sample data for the database.
     */
    private void InitializeData()
    {
        _playerCoins[1] = 1900;
        PlayerItems[1] = new List<int>();
        
        // Item samples
        _items[1] = new Item("1", "Full Moon Sword", 500);
        _items[2] = new Item("2", "Bloody Sword", 1000);
        _items[3] = new Item("3", "Great Sword", 1250);
    }

    /**
     * @brief Gets the item with the given id.
     * @param itemId Id of the item
     * @return Item with the given id
     */
    public Item? GetItem(int itemId)
    {
        return _items.ContainsKey(itemId) ? _items[itemId] : null;
    }

    /**
     * @brief Gets the coins of the player with the given id.
     * @param playerId Id of the player
     * @return Coins of the player with the given id
     */
    public decimal GetPlayerCoins(int playerId)
    {
        return _playerCoins.ContainsKey(playerId) ? _playerCoins[playerId] : 0;
    }
    
    /**
     * @brief Adds the item with the given id to the player with the given id.
     * @param playerId Id of the player
     * @param itemId Id of the item
     */
    public void AddItemToPlayer(int playerId, int itemId)
    {
        if (!PlayerItems.ContainsKey(playerId))
        {
            PlayerItems[playerId] = new List<int>();
        }
        
        PlayerItems[playerId].Add(itemId);
    }
    
    /**
     * @brief Updates the coins of the player with the given id.
     * @param playerId Id of the player
     * @param newCoinAmount New coin amount of the player
     */
    public void UpdatePlayerCoins(int playerId, decimal newCoinAmount)
    {
        _playerCoins[playerId] = newCoinAmount;
    }
}