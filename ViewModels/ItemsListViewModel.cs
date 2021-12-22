using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> allItems { get; set; }
        public string currCategory { get; set; }
    }
}
