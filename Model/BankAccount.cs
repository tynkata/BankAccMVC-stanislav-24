using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccMVC.Model
{
    internal class BankAccount
    {    
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Amount { get; set; }

            public BankAccount(int id, string name,   decimal amount)
            {
                Id = id;
                Name = name;
                Amount = amount;
            }
    }
}
