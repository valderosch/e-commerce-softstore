using SoftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Repository
{
    public interface IProduct
    {
        IEnumerable<Product> Products { get; set; }
        IEnumerable<Product> GetWishlist { get; set; }
        Product getObjProduct(int prodId);

    }
}
