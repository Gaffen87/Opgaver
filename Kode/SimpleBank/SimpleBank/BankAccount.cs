using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        public string Name { get; set; }

        private double _balance;
        public double Balance
        { 
            get
            {
                return _balance;
            } 
        }

        private bool locked = false;

        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            _balance = balance;
            this.locked = locked;
        }

        public BankAccount(string name, double balance) : this(name, balance, false) { }
        
        public BankAccount(double balance) : this("", balance, false) { }

        public void Deposit(double amount)
        {
            if (!locked)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (!locked)
            {
                if (_balance >= amount)
                {
                    _balance -= amount;
                }
            }           
        }

        public void ChangeLockState()
        {
            if (!locked)
            {
                locked = true;
            }
            else
            {
                locked = false;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Balance: {_balance}";
        }
    }
}
