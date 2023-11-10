using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Models
{
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string shortDescription { get; set; }
        public string productDescription { get; set; }
        public string image { get; set; }
        public ushort price { get; set; }
        public int amount { get; set; }
        public bool wishlist { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
