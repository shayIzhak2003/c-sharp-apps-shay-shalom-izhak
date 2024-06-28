using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.bank_app
{
    public class Account
    {
        private const int MAX_OVERDRAFT = 90000; 
        private Owner owner;
        private double balance;
        private int overdraft;

        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            SetOverdraft(overdraft);
        }

        public Owner GetOwner()
        {
            return this.owner;
        }
        public double GetBalance()
        {
            return this.balance;
        }
        public int GetOverDraft()
        {
            return this.overdraft;
        }

        public void SetOverdraft(int value)
        {
            if (value > MAX_OVERDRAFT)
            {
                Console.WriteLine($"Error: Attempted to set overdraft to {value}, which exceeds the maximum allowed overdraft of {MAX_OVERDRAFT}.");
            }
            else
            {
                overdraft = value;
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance - amount >= -overdraft)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine($"Error: Withdrawal of {amount} would exceed the overdraft limit of {-overdraft}.");
            }
        }
    }
}
