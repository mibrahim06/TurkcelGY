namespace SingleResponsibilityPricinciple_SRP;

/**
 * This class represents the items in the game.
 */
public class Item
{
    private string Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    
    /**
     * @brief Constructor for the Item class
     * @param id Id of the item
     * @param name Name of the item
     * @param price Price of the item
     */
    public Item(string id, string name, string price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}