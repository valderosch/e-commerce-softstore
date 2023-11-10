using SoftStore.Models;
using SoftStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Repos
{
    public class CategoryRepository : IProductCategory
    {
        private readonly AppDbContext appDbContent;

        public CategoryRepository(AppDbContext appDbCont)
        {
            this.appDbContent = appDbCont;
        }
        public IEnumerable<Category> ShowAllCategories => appDbContent.categoty;
    }
}
