using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Models
{
    public class Cart
    {
        private readonly AppDbContext appDbContent;

        public Cart(AppDbContext appDbCont)
        {
            this.appDbContent = appDbCont;
        }

        public string id { get; set; }
        public List<CartItem> itemsList { get; set; }

        public static Cart GetCart(IServiceProvider services) 
        {
            ISession session = services.GetRequiredService<HttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", shopCartId);

            return new Cart(context) { id = shopCartId };
        }

        public void AddToCart(Product product)
        {
            this.appDbContent.cartItem.Add(new CartItem
            {
                product = product,
                price = product.price
            });
            appDbContent.SaveChanges();
        }

        public List<CartItem> gettAllProducts()
        {
            return appDbContent.cartItem.Where(c => c.product.id.Equals(id)).Include(s => s.product).ToList();
        }
    }
}
