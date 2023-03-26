namespace OpenClosedPrinciple;

public class Item
{
    private int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public Item(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

}
