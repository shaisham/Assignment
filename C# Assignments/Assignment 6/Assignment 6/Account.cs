using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Account
    {
  
        public int AcNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public delegate void BalanceEventHendler(object source, object B);
        public event BalanceEventHendler LowOrZeroBalanced;

        protected virtual void OnLowOrZeroBalanced()
        {
            if (LowOrZeroBalanced != null)
            {
                LowOrZeroBalanced(this, this.Balance);
            }
        }

        public Account(int acn, string cun, double bal)
        {
            AcNumber = acn;
            CustomerName = cun;
            Balance = bal;
        }

        public double Deposit(double value)
        {
            Balance += value;
            return Balance;
        }

        public double Withdraw(double val)
        {
            Balance -= val;
            return Balance;
        }

        public bool IsUnderBalance()
        {
            if (Balance < 3300)
            {
                OnLowOrZeroBalanced();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsBalanceZero()
        {
            if (Balance == 0)
            {
                OnLowOrZeroBalanced();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class MailService
    {
        public void OnLowOrZeroBalanced(object source, object B)
        {
            Console.WriteLine($"MailService: Your Account Balance is below minimum balance,\nYour Current Balance is : {B}");
        }
    }

    public class MainP
    {

        public static void Main(string[] args)
        {
            Account a1 = new Account(13212543, "Mahafuz", 2000);
            var mailService = new MailService();

            a1.LowOrZeroBalanced += mailService.OnLowOrZeroBalanced;
            a1.IsUnderBalance();
        }
    }
}

