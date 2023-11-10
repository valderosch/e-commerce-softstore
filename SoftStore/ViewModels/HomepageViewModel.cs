using SoftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.ViewModels
{
    public class HomepageViewModel
    {
        public IEnumerable<Product> favProds { get; set; }
    }
}
