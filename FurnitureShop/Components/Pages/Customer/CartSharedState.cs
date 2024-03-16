using FurnitureShop.Models;

namespace FurnitureShop.Components.Pages.Customer;

public static class CartSharedState
{
    public static Dictionary<Furniture, int> FurnitureInCart { get; private set; } = []; // item - count

    public static void AddToCart(Furniture furniture)
    {
        foreach(var item in FurnitureInCart)
        {
            if (item.Key.Id == furniture.Id)
            {
                FurnitureInCart[item.Key]++;
                return;
            }
        }

        FurnitureInCart.Add(furniture, 1);
    }

    public static void RemoveFromCart(Furniture furniture)
    {
        FurnitureInCart.Remove(furniture);
    }

    public static void ClearCart() => FurnitureInCart.Clear();
}
