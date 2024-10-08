using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccMVC.View
{
    public class BankAccountView
    {
        public void DisplayAccountDetails(BankAccount account) =>
            Console.WriteLine($"Id: {account.Id}, Amount: {account.Amount}, Name: {account.Name}");

        public void DisplayMessage(string message) => Console.WriteLine(message);
    }

}

