using SoftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> allProducts { get; set; }
        public List<string> AllCategories { get; set; }
        public string currentCategory { get; set; }
    }
}
