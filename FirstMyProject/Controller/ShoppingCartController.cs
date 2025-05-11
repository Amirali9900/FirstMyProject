using FirstMyProject.Models;
using FirstMyProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstMyProject.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IShoppingCart _shoppingCart;
        private readonly ICakeRepository _cakeRepository;

        public ShoppingCartController(IShoppingCart shoppingCart, ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }


        public RedirectToActionResult AddToShoppingCart(int cakeId)
        {
            var selectCake = _cakeRepository.AllCake.FirstOrDefault(p => p.CakeId == cakeId);

            if (selectCake != null)
            {
                _shoppingCart.AddToCart(selectCake);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int cakeId)
        {
            var selectCake = _cakeRepository.AllCake.FirstOrDefault(p => p.CakeId == cakeId);

            if (selectCake != null)
            {
                _shoppingCart.RemoveFromCart(selectCake);
            }

            return RedirectToAction("Index");
        }
    }
}
