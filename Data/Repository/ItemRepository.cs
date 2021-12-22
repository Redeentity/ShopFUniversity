using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.Repository
{
    public class ItemRepository : IAllItems
    {
        private readonly AppDBContent appDBContent;
        public ItemRepository(AppDBContent appDBContent) 
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Item> Items => appDBContent.Item.Include(c => c.Category);

        public IEnumerable<Item> getFavItems => appDBContent.Item.Where(p => p.isFavourite).Include(c => c.Category);


        public Item getObject(int itemID) => appDBContent.Item.FirstOrDefault(p => p.id == itemID);
    }
}
