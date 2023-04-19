using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class BankAccount
    {

        private decimal balance;


        public void Deposit(decimal deposit)

        {
          balance = balance + deposit;
        }

        public void withdraw(decimal amount)
        {
            if (amount > balance)

            {
              throw new InvalidOperationException("Insufficient funds");


            }
            
            balance = balance - amount;
        
        
        }
    
        public decimal getBalance()
        {
            
            return balance; 
        
        
        }
    
        public static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();
            bank.Deposit(1000);
            bank.balance = 1000;
            Console.WriteLine(bank.getBalance());
            bank.withdraw(300);
            Console.WriteLine(bank.getBalance());
            bank.Deposit(50000);
            Console.WriteLine(bank.getBalance());
            bank.withdraw(23000);
            Console.WriteLine(bank.getBalance());
            bank.withdraw(80000);
            Console.WriteLine(bank.getBalance() );


        }


    }
}
