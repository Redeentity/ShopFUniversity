using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.Mocks
{
    public class MockItems : IItemsCategory
    {
        private readonly IItemsCategory _CategoryItems = new MockCategory();
        public IEnumerable<Item> Items {
            get {
                return new List<Item>
                {
                    new Item {name = "Meat", shortDesc = "", longDesc = "", img = "", price = 100, isFavourite = true, available = true, Category = _CategoryItems.AllCategories.First()},
                    new Item {name = "Fish", shortDesc = "", longDesc = "", img = "", price = 220, isFavourite = false, available = false, Category = _CategoryItems.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Item> getFavItems { get; set; }

        public IEnumerable<Category> AllCategories => throw new NotImplementedException();

        public Item getObject(int itemID)
        {
            throw new NotImplementedException();
        }
    }
}
