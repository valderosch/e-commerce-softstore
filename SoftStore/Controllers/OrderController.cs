using Microsoft.AspNetCore.Mvc;
using SoftStore.Models;
using SoftStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrder iallorders;
        private readonly Cart cart;

        public OrderController(IOrder iallorders, Cart cart)
        {
            this.iallorders = iallorders;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
