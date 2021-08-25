using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Scopic.Service.Services
{
    public interface IAccountService
    {
        User GetUser(int Id);
        User Login(string username, string password);
    }
}