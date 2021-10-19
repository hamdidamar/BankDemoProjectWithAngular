using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountService accountService;
        public AccountController()
        {
            accountService = new AccountManager(new AccountDal());
        }

        [HttpGet("GetAllAccounts")]
        public List<Account> GetAllAccounts()
        {
            return accountService.GetAll();
        }

        [HttpGet("GetAccountsOfUser")]
        public List<Account> GetAccountsOfUser([FromQuery] int userId)
        {
            return accountService.GetAll(a => a.UserId == userId);
        }

        [HttpGet("GetAccountById")]
        public Account GetAccountById([FromQuery] int accountId)
        {
            return accountService.Get(a => a.AccountId == accountId);
        }

        [HttpPost("AddAccount")]
        public string AddAccount([FromBody] Account account)
        {
            var res = accountService.Add(account);
            var message = "";
            if (res == 1)
            {
                message = "Account added succesfuly" + " " + "id:" + account.AccountId + " " + "name:" + account.AccountName;
            }
            else
            {
                message = "Account cannot added" + account.AccountName;
            }

            return message;
        }

        [HttpPut("UpdateAccount")]
        public string UpdateAccount([FromBody] Account account)
        {
            var res = accountService.Update(account);
            var message = "";
            if (res == 1)
            {
                message = "Account updated succesfuly" + " " + "id:" + account.AccountId + " " + "name:" + account.AccountName;
            }
            else
            {
                message = "Account cannot updated" + account.AccountName;
            }

            return message;
        }

        [HttpPut("AddMoney")]
        public string AddMoney([FromBody] Account account, decimal amount)
        {
            var res = accountService.AddMoney(amount, account);
            var message = "";
            if (res)
            {
                message = "Modey added to account succesfuly";
            }
            else
            {
                message = "Modey cannot added to account";
            }

            return message;
        }

        [HttpPut("TakeMoney")]
        public string TakeMoney([FromBody] Account account, decimal amount)
        {
            var res = accountService.TakeMoney(amount, account);
            var message = "";
            if (res)
            {
                message = "Modey taked succesfuly";
            }
            else
            {
                message = "Modey cannot taked";
            }

            return message;
        }

        [HttpDelete("DeleteAccount")]
        public string DeleteAccount([FromBody] Account account)
        {
            var res = accountService.Delete(account);
            var message = "";
            if (res == 1)
            {
                message = "Account deleted succesfuly";
            }
            else
            {
                message = "Account cannot deleted" + " " + "id:" + account.AccountId + " " + "name:" + account.AccountName;
            }

            return message;
        }


    }
}
