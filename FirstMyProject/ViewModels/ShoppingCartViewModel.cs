using FirstMyProject.Models;

namespace FirstMyProject.ViewModels
{
    public class ShoppingCartViewModel
    {
        internal static object _shoppingCart;

        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
        }

        public IShoppingCart ShoppingCart { get; }
        public decimal ShoppingCartTotal { get; }
    }
}
