using Microsoft.AspNetCore.Mvc;
using SoftStore.Models;
using SoftStore.Repository;
using SoftStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _allProducts;
        private readonly IProductCategory _allCategories;

        public ProductController(IProduct product, IProductCategory category)
        {
            _allProducts = product;
            _allCategories = category;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ProductsViewModel obj = new ProductsViewModel();
            obj.allProducts = _allProducts.Products;
            obj.currentCategory = "All";
            ViewBag.Categories = _allCategories.ShowAllCategories.Select(c => c.categoryName).ToList();
            ViewBag.CurrentCategory = obj.currentCategory;

            return View(obj);
        }

        public IActionResult PostsByCategory(int categoryId)
        {
            var products = _allProducts.Products
            .Where(prod => prod.categoryID == categoryId);
            return View("Index", new ProductsViewModel { allProducts = products, currentCategory = categoryId.ToString()});
        }
    }
}
