using Scopic.Data.Context;
using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scopic.Service.Services
{
    public class ItemService : IItemService
    {

        private readonly DatabaseContext _database;
        public ItemService ()
        {
            _database = new DatabaseContext();
        }

        public Item GetItem(int id)
        {
            return _database.ProductItems.Find(id);
        }


        public IEnumerable<Item> GetItems()
        {
            return _database.ProductItems;
        }

        public void UpdateItem(int id, Item item)
        {
            var toUpdatedItem = _database.ProductItems.Find(id);
            toUpdatedItem.Id = item.Id;
            toUpdatedItem.Name = item.Name;
            toUpdatedItem.Sold = item.Sold;
            toUpdatedItem.Description = item.Description;
            toUpdatedItem.ListPrice = item.ListPrice;
            _database.Entry(toUpdatedItem).State = System.Data.Entity.EntityState.Modified;
            _database.SaveChanges();
        }
    
    }
}