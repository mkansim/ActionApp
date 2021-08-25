using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scopic.Service.Services
{
    public interface IItemService
    {
        void UpdateItem(int id, Item item);
        IEnumerable<Item> GetItems();
        Item GetItem(int id);
    }


}
