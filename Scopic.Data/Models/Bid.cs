using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scopic.Data.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int BidderUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double InitialPrice { get; set; }
        public double CurrentBidPrice { get; set; }
        public bool AutoBidActivated { get; set; }
        public bool BidAccepted { get; set; }
    }
}