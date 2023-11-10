using Microsoft.EntityFrameworkCore;
using SoftStore.Models;
using SoftStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Repos
{
    public class ProductRepository : IProduct
    {
        private readonly AppDbContext appDbContent;
        
        public ProductRepository(AppDbContext appDbCont)
        {
            this.appDbContent = appDbCont;
        }

        public IEnumerable<Product> Products { get => appDbContent.product.Include(c => c.Category); set => throw new NotImplementedException(); }
        public IEnumerable<Product> GetWishlist { get => appDbContent.product.Where(p => p.wishlist).Include(c => c.Category); set => throw new NotImplementedException(); }

        public Product getObjProduct(int prodId) => appDbContent.product.FirstOrDefault(p => p.id == prodId);
    }
}
