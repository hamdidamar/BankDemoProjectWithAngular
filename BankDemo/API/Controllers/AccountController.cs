using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        AccountManager accountManager;
        public AccountController()
        {
            accountManager = new AccountManager(new AccountDal());
        }

        [HttpGet]
        public List<Account> GetAccountsOfUSer([FromQuery] int userId)
        {
            return accountManager.GetAll(a => a.UserId == userId);
        }


    }
}
