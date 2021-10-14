using Entity;
using Shared.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountService : IService<Account>
    {
        bool AddMoney(decimal amount,Account account);
        bool TakeMoney(decimal amount,Account account);
    }
}
