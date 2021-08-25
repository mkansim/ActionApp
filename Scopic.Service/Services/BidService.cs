using Scopic.Data.Context;
using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scopic.Service.Services
{
    public class BidService : IBidService
    {
        private readonly DatabaseContext _database;
        public BidService()
        {
            _database = new DatabaseContext();
        }

        public Bid CreateBid(Bid bid)
        {
            _database.Bids.Add(bid);
            _database.SaveChanges();
            return bid;
        }

        public IEnumerable<Bid> GetBids()
        {
            return _database.Bids.ToList();
        }

        public Bid GetUserBid(int userId)
        {
            var bid =_database.Bids.FirstOrDefault(x => x.BidderUserId == userId);
            return bid;
        }

        public Bid UpdateBid(int id, Bid bid)
        {
            var toUpdatedbid = _database.Bids.Find(id);

            if (toUpdatedbid == null)
            {
                return null;
            }
            
            toUpdatedbid.AutoBidActivated = bid.AutoBidActivated;
            toUpdatedbid.CreateDate = bid.CreateDate;
            toUpdatedbid.ExpiryDate = bid.ExpiryDate;
            toUpdatedbid.Id = bid.Id;
            toUpdatedbid.ItemId = bid.ItemId;
            toUpdatedbid.InitialPrice = bid.InitialPrice;
            toUpdatedbid.BidAccepted = bid.BidAccepted;

            if (bid.AutoBidActivated)
            {
                toUpdatedbid.CurrentBidPrice = bid.CurrentBidPrice + 1;
                toUpdatedbid.BidderUserId = toUpdatedbid.BidderUserId;
            }
            else
            {
                toUpdatedbid.CurrentBidPrice = bid.CurrentBidPrice + 1;
                toUpdatedbid.BidderUserId = bid.BidderUserId;
            }
            _database.Entry(toUpdatedbid).State = System.Data.Entity.EntityState.Modified;
            _database.SaveChanges();
            return toUpdatedbid;
        }
    }
}