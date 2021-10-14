using Business.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        public int Add(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool AddMoney(decimal amount, Account account)
        {
            throw new NotImplementedException();
        }

        public int Delete(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account Get(Expression<Func<Account, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll(Expression<Func<Account, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool TakeMoney(decimal amount, Account account)
        {
            throw new NotImplementedException();
        }

        public int Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
