namespace FurnitureShop.Components.Pages.Manager.Views;

public partial class Suppliers
{
    public class Supplier(string supplierName, string furnitureName, int offeredPrice)
    {
        public string Name { get; set; } = supplierName;
        public string FurnitureName { get; set; } = furnitureName;
        public int OfferedPrice { get; set; } = offeredPrice;
    }

    public List<string> NotRealCompanyNames =
    [
        "Company #1",
        "Furniture supplier ltd",
        "CommonNameCompany",
        "Bed&Pet",
        "BigWardrobe LLC",
        "Wooden goods",
        "Some local supplier",
        "LowestPricesCompany",
        "StateFirmFurniture",
        "Famous Furniture Firm (FFF)"
    ];
}
