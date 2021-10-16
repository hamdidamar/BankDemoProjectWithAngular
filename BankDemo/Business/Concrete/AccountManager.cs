using Business.Abstract;
using DataAccess.Abstract;
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
        IAccountDal _accountDal;
        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        public int Add(Account entity)
        {
            return _accountDal.Add(entity);
        }

        public bool AddMoney(decimal amount, Account account)
        {
            return _accountDal.AddMoney(amount,account);
        }

        public int Delete(Account entity)
        {
            return _accountDal.Delete(entity);
        }

        public Account Get(Expression<Func<Account, bool>> filter)
        {
            return _accountDal.Get(filter);
        }

        public List<Account> GetAll(Expression<Func<Account, bool>> filter = null)
        {
            return _accountDal.GetAll(filter);
        }

        public bool TakeMoney(decimal amount, Account account)
        {
            return _accountDal.TakeMoney(amount,account);
        }

        public int Update(Account entity)
        {
            return _accountDal.Update(entity);
        }
    }
}
