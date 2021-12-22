using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if(content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if(content.Item.Any())
            {
                content.AddRange(
                    new Item { name = "Meat", shortDesc = "Properly cooked and juicy", longDesc = "", img = "/img/meat.jpg", price = 55, isFavourite = true, available = true, Category = Categories["Meat"] },
                    new Item { name = "Beef Steak", shortDesc = "Big, well-grilled steak", longDesc = "", img = "/img/steak.jpg", price = 25, isFavourite = true, available = true, Category = Categories["Meat"] },
                    new Item { name = "King-sized burger", shortDesc = "", longDesc = "", img = "/img/burger.jpg", price = 10, isFavourite = false, available = true, Category = Categories["Meat"] },
                    new Item { name = "White fish with lemon", shortDesc = "", longDesc = "", img = "/img/fish.jpg", price = 45, isFavourite = false, available = true, Category = Categories["Fish"] },
                    new Item { name = "Fried chicken", shortDesc = "", longDesc = "", img = "/img/friedchick.jpg", price = 25, isFavourite = false, available = true, Category = Categories["Meat"] },
                    new Item { name = "Grilled salmon", shortDesc = "", longDesc = "", img = "/img/salmon.jpg", price = 99, isFavourite = true, available = true, Category = Categories["Fish"] },
                    new Item { name = "White fish with FF", shortDesc = "", longDesc = "", img = "/img/fwff.jpg", price = 49, isFavourite = true, available = true, Category = Categories["Fish"] }


                    );
            }
            content.SaveChanges();
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
                        new Category {categoryName  = "Meat", desc = "You'll like it!"},
                        new Category {categoryName = "Fish", desc = "The best fish is here!"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
