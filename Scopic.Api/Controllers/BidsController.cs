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

    public class BidsController : ApiController
    {
        IItemService _itemService;
        IBidService _bidService;
        IUserBalanceService _userBalanceService;
        public BidsController()
        {
            _itemService = new ItemService();
            _bidService = new BidService();
            _userBalanceService = new UserBalanceService();
        }

        //[HttpGet]
        //public Item Item(int id)
        //{
        //    Item item = _itemService.GetItem(id);
        //    if (item == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return item;
        //}

        [HttpPut]
        public IHttpActionResult Bid(int id, Bid bid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var updatedBid = _bidService.UpdateBid(id, bid);
            if (updatedBid == null)
            {
                return NotFound();
            }
            return Ok(bid);
        }

        [HttpPost]
        public IHttpActionResult CreateBid(Bid bid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var createdBid = _bidService.CreateBid(bid);
            return Created(new Uri(Request.RequestUri + "/" + bid.Id), bid) ;
        }

        [HttpGet]
        public IHttpActionResult GetBids()
        {
            var bids = _bidService.GetBids();
            if (bids == null)
            {
                return NotFound();
            }
            return Ok(bids);
        }



        //[HttpGet]
        //public IEnumerable<Item> Items()
        //{
        //    var items = _itemService.GetItems();
        //    if (items == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return items;

        //}

        


    }
}
