using FirstMyProject.Models;
using FirstMyProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstMyProject.Componnents
{
    public class ShoppingCartSummery : ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartSummery(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }
    }
}
