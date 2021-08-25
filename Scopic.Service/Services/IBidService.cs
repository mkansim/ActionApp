using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scopic.Service.Services
{
    public interface IBidService
    {
        Bid CreateBid(Bid bid);
        Bid UpdateBid(int id, Bid bid);
        IEnumerable<Bid> GetBids();
        Bid GetUserBid(int userId);
    }
}
