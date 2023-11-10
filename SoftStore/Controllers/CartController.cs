using Microsoft.AspNetCore.Mvc;
using SoftStore.Models;
using SoftStore.Repos;
using SoftStore.Repository;
using SoftStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Controllers
{
    public class CartController : Controller
    {
        private readonly IProduct _product;
        private readonly Cart _cart;

        public CartController(IProduct product, Cart cart)
        {
            _product = product;
            _cart = cart;
        }
        public ViewResult Index()
        {
            var items = _cart.gettAllProducts();
            _cart.itemsList = items;

            var obj = new CartViewModel
            {
                Cart = _cart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _product.Products.FirstOrDefault(item => item.id == id);
            if(item != null) 
            {
                _cart.AddToCart(item);
            }
            Console.WriteLine($"Added to cart: {item.productName}");
            return RedirectToAction("Index");
        }
    }
}
