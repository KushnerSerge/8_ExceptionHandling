using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ExceptionHandling
{
    public class BankAccount
    {
        public bool logedIn = false;
        public static int securePoint = 1;
        public string Name { get; set; }
        private string Password { get; set; }
        public int Amount { get; set; }

        public BankAccount(string name, string password, int amount)
        {
            Name = name;
            Password = password;
            Amount = amount;
        }

        public void Login(string password)
        {
            if (Password == password && securePoint < 3)
            {
                Console.WriteLine($"{Name}, You are succesfull logedIn");
                Console.WriteLine($"{Name}, Your amount is : {Amount}");
                logedIn = true;
                securePoint = 1;

            }
            else if (Password != password && securePoint < 3)
            {
                Console.WriteLine("Your password is incorect please try again");
                Console.WriteLine($"you have {3 - securePoint} more tries");
                logedIn = false;
                securePoint++;
            }
            else
            {
                Console.WriteLine("You have no more tries ");
                Console.WriteLine("Your Account is blocked, Please call your manager bank account");
                securePoint = 1;
                logedIn = false;
                throw new AccountLoginException("Account is blocked due to 3 wrong tries to login ");
            }

        }

        public void WithDraw(int amount_money)
        {
            if (Amount < amount_money)
            {
                throw new NotEnoughMoneyException("You don't have enouth money to withdraw");
            }
            else
            {
                Amount -= amount_money;
                Console.WriteLine($"You withdram {amount_money} money, and your bank account has {Amount} of money");
            }
        }

    }
}
