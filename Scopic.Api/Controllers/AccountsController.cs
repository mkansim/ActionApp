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
    public class AccountsController : ApiController
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IHttpActionResult GetUser(int id)
        {
            User user = _accountService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(User);
        }

        [HttpGet]
        public IHttpActionResult Login(string username, string password)
        {
            User user = _accountService.Login(username, password);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(User);
        }



    }
}
