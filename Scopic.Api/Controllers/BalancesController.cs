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
    public class BalancesController : ApiController
    {
        IUserBalanceService _userBalanceService;
        public BalancesController()
        {
            _userBalanceService = new UserBalanceService();

        }

        [HttpGet]
        public IHttpActionResult GetUserBalance(int userId)
        {
            var balance = _userBalanceService.GetUserBalance(userId);
            if (balance == null)
            {
                return NotFound();
            }
            return Ok(balance);
        }

        [HttpPut]
        public IHttpActionResult UpdateBalance(int id, UserBalance userBalance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var updatedUserBalance = _userBalanceService.UpdateUserBalance(id, userBalance);
            if (updatedUserBalance == null)
            {
                return NotFound();
            }
            return Ok(userBalance);
        }
    }
}
