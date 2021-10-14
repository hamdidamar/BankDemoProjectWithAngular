using Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Account:IEntity
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal Total { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
