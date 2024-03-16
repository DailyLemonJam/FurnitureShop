namespace FurnitureShop.Models;

public class Order
{
    public int Id { get; set; }
    public string? CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    public List<string>? OrderedFurnitureNames { get; set; } // TODO Change to Furniture Type?
    public DateTime OrderDate { get; set; }
    public int PriceWhenOrdered { get; set; }
}
