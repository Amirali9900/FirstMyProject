﻿using Microsoft.EntityFrameworkCore;

namespace FirstMyProject.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly CakeShopDbContext _cakeShopDbContext;

        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set ; } = default!;

        private ShoppingCart(CakeShopDbContext cakeShopDbContext)
        {
            _cakeShopDbContext = cakeShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>() ?.HttpContext?.Session;

            CakeShopDbContext context = services.GetService<CakeShopDbContext>() ?? throw new Exception("Error initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Cake cake)
        {
            var shoppingCartItem = _cakeShopDbContext.shoppingCartItems.SingleOrDefault(s => s.Cake.CakeId == cake.CakeId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem != null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Cake = cake,
                    Amount = 1
                };
                _cakeShopDbContext.shoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _cakeShopDbContext.SaveChanges();
        }

        public int RemoveFromCart(Cake cake)
        {
            var shoppingCartItem = _cakeShopDbContext.shoppingCartItems.SingleOrDefault(s => s.Cake.CakeId == cake.CakeId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _cakeShopDbContext.shoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _cakeShopDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _cakeShopDbContext.shoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Cake).ToList();
        }

        public void ClearCart()
        {
            var cartItems = _cakeShopDbContext.shoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _cakeShopDbContext.shoppingCartItems.RemoveRange(cartItems);
            _cakeShopDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _cakeShopDbContext.shoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Cake.Price * c.Amount).Sum();

            return total;
        }
    }
}
