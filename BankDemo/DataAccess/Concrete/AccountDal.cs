using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class AccountDal : RepositoryBase<Account, Context>, IAccountDal
    {
        public bool AddMoney(decimal amount, Account account)
        {
            throw new NotImplementedException();
        }

        public bool TakeMoney(decimal amount, Account account)
        {
            throw new NotImplementedException();
        }
    }
}
