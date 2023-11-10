using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Models
{
    public class CartItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int price { get; set; }
    }
}
