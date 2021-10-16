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
            using (Context context = new Context())
            {
                var updateAccount = context.Accounts.SingleOrDefault(a => a.AccountId == account.AccountId);
                updateAccount.Total += amount;
                var res = context.SaveChanges();
                return res == 1 ? true : false;

            }
        }

        public bool TakeMoney(decimal amount, Account account)
        {
            using (Context context = new Context())
            {
                var updateAccount = context.Accounts.SingleOrDefault(a => a.AccountId == account.AccountId);
                updateAccount.Total -= amount;
                var res = context.SaveChanges();
                return res == 1 ? true : false;

            }
        }
    }
}
