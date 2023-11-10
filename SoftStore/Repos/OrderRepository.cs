using SoftStore.Models;
using SoftStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Repos
{
    public class OrderRepository : IOrder
    {
        private readonly AppDbContext appDbContext;
        private readonly Cart cart;

        public OrderRepository(AppDbContext dbContext, Cart cart)
        {
            this.appDbContext = dbContext;
            this.cart = cart;
        } 
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContext.order.Add(order);

            var items = cart.itemsList;

            foreach(var elem in items)
            {
                var orderDetail = new OrderDetails()
                {
                    productId = elem.product.id,
                    orderId = order.id,
                    price = elem.product.price,
                };
                appDbContext.OrderDetails.Add(orderDetail);
            }

            appDbContext.SaveChanges();
        }
    }
}
