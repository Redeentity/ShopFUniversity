using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class ItemsController : Controller   
    {
        private readonly IAllItems _allItems;
        private readonly IItemsCategory _allCategories;
        public ItemsController(IAllItems iAllItems, IItemsCategory iItemsCat)
        {
            _allItems = iAllItems;
            _allCategories = iItemsCat;
        }

        [Route("Items/List")]
        [Route("Items/List/{category}")]
        public ViewResult List(string category)
        { 
            string _category = category;
            IEnumerable<Item> items = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                items = _allItems.Items.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("Meat", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Meat")).OrderBy(i => i.id);
                }
                else if (string.Equals("Fish", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Fish")).OrderBy(i => i.id);
                }
                currCategory = _category;
            }
            var itemObj = new ItemsListViewModel
            {
                allItems = items,
                currCategory = currCategory
            };
            ViewBag.Title = "Dishes page";
            return View(itemObj);
        }

    }
}
