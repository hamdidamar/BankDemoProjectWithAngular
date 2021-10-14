using Entity;
using Shared.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAccountDal : IRepository<Account>
    {
        bool AddMoney(decimal amount, Account account);
        bool TakeMoney(decimal amount, Account account);
    }
}
