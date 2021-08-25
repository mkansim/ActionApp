using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scopic.Service.Services
{
    public interface IUserBalanceService
    {
        UserBalance GetUserBalance(int userId);
        UserBalance UpdateUserBalance(int userId, UserBalance userBalance);
    }
}
