using Scopic.Data.Models;
using Scopic.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Scopic.Api.Controllers
{
    [EnableCors(origins: "http://localhost:400", headers: "*", methods: "*")]
    public class ItemsController : ApiController
    {
        IItemService _itemService;

        public ItemsController()
        {
            _itemService = new ItemService();
        }

        [HttpGet]
        public Item Item(int id)
        {
            Item item = _itemService.GetItem(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpGet]
        public IHttpActionResult GetItems()
        {
            var items = _itemService.GetItems();
            if (items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }

        [HttpPut]
        public void UpdateItem(int id, Item item)
        {
            _itemService.UpdateItem(id, item);
        }

    }
}
