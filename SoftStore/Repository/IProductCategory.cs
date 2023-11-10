using SoftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore.Repository
{
    public interface IProductCategory
    {
        IEnumerable<Category> ShowAllCategories { get; }
    }
}
