namespace FirstMyProject.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CakeShopDbContext _cakeShopDbContext;
        private readonly IShoppingCart _shoppingCart;


        public OrderRepository(CakeShopDbContext cakeShopDbContext, IShoppingCart shoppingCart)
        {
            _cakeShopDbContext = cakeShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OederTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Cake.Price,
                    CakeId = shoppingCartItem.Cake.CakeId
                };

                order.OrderDetails.Add(orderDetail);
            }

            _cakeShopDbContext.Orders.Add(order);
            _cakeShopDbContext.SaveChanges();
        }
    }
}
