namespace SingleResponsibilityPricinciple_SRP;

/**
 * This program is sample for Single Responsibility Principle (SRP) and  simulates a simple item shop in Metin2 game.
 * There are 3 classes in this program:
 * 1. Database: This class is responsible for storing and retrieving data from database.
 * 2. ItemShop: This class is responsible for purchasing items from the shop.
 * 3. Item: This class represents an items in the game.
 */
abstract class Program
{
    static void Main()
    {
        Database database = new Database();
        ItemShop itemShop = new ItemShop(database);
        
        // Sample Player and Item
        int playerId = 1;
        int itemId = 1;
        var item = database.GetItem(itemId);
        Console.WriteLine($"Player {playerId} has {database.GetPlayerCoins(playerId)} coins");
        Console.WriteLine($"Player {playerId} has {database.PlayerItems[playerId].Count} items");
        Console.WriteLine(new string('-', 50));
        // Player buys item
        Console.WriteLine(itemShop.PurchaseItem(playerId, itemId)
            ? $"Player {playerId} has bought item {item?.Name}"
            : $"Player {playerId} could not buy item {item?.Name}");
        Console.WriteLine($"Player {playerId} has {database.GetPlayerCoins(playerId)} coins");
        Console.WriteLine($"Player {playerId} has {database.PlayerItems[playerId].Count} items");
        Console.WriteLine(new string('-', 50));
        
        // Player buys new item
        itemId = 3;
        var item2 = database.GetItem(itemId);
        Console.WriteLine(itemShop.PurchaseItem(playerId, itemId)
            ? $"Player {playerId} has bought item {item2?.Name}"
            : $"Player {playerId} could not buy item {item2?.Name}");
        Console.WriteLine($"Player {playerId} has {database.GetPlayerCoins(playerId)} coins");
        Console.WriteLine($"Player {playerId} has {database.PlayerItems[playerId].Count} items");
        Console.WriteLine(new string('-', 50));
        
        // Player buys new item
        itemId = 2;
        var item3 = database.GetItem(itemId);
        if (itemShop.PurchaseItem(playerId, itemId))
        {
            Console.WriteLine($"Player {playerId} has bought item {item3?.Name}");
        }
        else
        {
            Console.WriteLine($"Player {playerId} could not buy item {item3?.Name}");
            Console.WriteLine($"Item {item3?.Name} costs {database.GetItem(itemId)?.Price} coins but player {playerId} only has {database.GetPlayerCoins(playerId)} coins");
        }
        Console.WriteLine($"Player {playerId} has {database.GetPlayerCoins(playerId)} coins");
        Console.WriteLine($"Player {playerId} has {database.PlayerItems[playerId].Count} items");
        Console.WriteLine(new string('-', 50));
    }
}
