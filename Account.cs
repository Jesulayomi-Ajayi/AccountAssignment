using System;

namespace AccountAssignment
{
    public class Account
    {
        private string firstName;
        private string lastName;
        private string bvn;
        private decimal accountBalance;

        public Account(string fname, string lname, string _bvn, decimal balance)
        {
            FirstName = fname;
            LastName = lname;
            Bvn = _bvn;
            AccountBalance = balance;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Bvn
        {
            get
            {
                return bvn;
            }
            set
            {
                bvn = value;
            }
        }

        public Decimal AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                if(value >= 0)
                {
                    accountBalance = value;
                }
                else
                {
                    throw new Exception("Initial balance must be greater than 0");
                }
            }
        }

        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                AccountBalance = AccountBalance + amount;
                //AccountBalance += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }

        public virtual bool Debit(decimal amount)
        {
            if (AccountBalance >= amount)
            {
                AccountBalance -= amount;
                return true;
            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                return false;
            }
        }
    }
}
