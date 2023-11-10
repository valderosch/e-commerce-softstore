using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SoftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore
{
    public class DbData
    {
        public static void Initial(AppDbContext context)
        {
            if (!context.categoty.Any())
                context.categoty.AddRange(Categories.Select(c => c.Value));

            if (!context.product.Any())
                context.product.AddRange(Products.Select(p => p.Value));

            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                            new Category {categoryName = "PhotoCamera", categoryDescription = "Can takes photo" },
                            new Category {categoryName = "ActionCamera", categoryDescription = "Can record video"},
                            new Category {categoryName = "Stabilisation", categoryDescription = "Can stabilisate the Image"},
                            new Category {categoryName = "Light", categoryDescription = "Can throw light"},
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.categoryName, item);
                    }
                }
                return category;
            }
        }

        private static Dictionary<string, Product> product;
        public static Dictionary<string, Product> Products
        {
            get
            {
                if(product == null)
                {
                    var prodlist = new Product[]
                    {
                        new Product {
                            productName = "Nikon A210",
                            productDescription = "" +
                        "Very cool camera for beginers. Can take photos at resolution 4000 x 3000 without quality loses" +
                        "Smart and fast processor, big lense",
                            shortDescription = "Cool camera for beginers",
                            price = 1100,
                            amount = 35,
                            wishlist=true,
                            image = "./img/camera/111",
                            Category = Categories["PhotoCamera"]
                        },

                        new Product {
                            productName = "Canon 610D",
                            productDescription = "" +
                        "Very cool camera for beginers. Can take photos at resolution 4000 x 3000 without quality loses" +
                        "Smart and fast processor, big lense",
                            shortDescription = "Cool camera for Profesionals",
                            price = 3500,
                            amount = 20,
                            wishlist=false,
                            image = "./img/camera/333",
                            Category = Categories["PhotoCamera"]
                            },

                        new Product {
                            productName = "Lumex 1200k",
                            productDescription = "" +
                        "Lightly and powerful light. Can throw light up to 5 meter in range 1000-9000K" +
                        "Variance in work, light, and simply",
                            shortDescription = "Good Light",
                            price = 500,
                            amount = 5,
                            wishlist=true,
                            image = "./img/light/111",
                            Category = Categories["Light"]
                        },
                    };

                    product = new Dictionary<string, Product>();
                    foreach (Product itm in prodlist)
                    {
                        product.Add(itm.productName, itm);
                    }
                }
                return product;
            }
        }
    }
}
    

        
