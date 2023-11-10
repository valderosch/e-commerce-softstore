using Microsoft.AspNetCore.Mvc;
using SoftStore.Repository;
using SoftStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _prodRep;
    

        public HomeController(IProduct product)
        {
            _prodRep = product;
        }

        public ViewResult Index()
        {
            var products = new HomepageViewModel
            {
                favProds = _prodRep.GetWishlist
            };
            return View(products);
        }
        
    }
}
