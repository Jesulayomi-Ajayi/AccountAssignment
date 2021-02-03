using System;

namespace AccountAssignment
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;
        public SavingsAccount(string fname, string lname, string bvn, decimal balance, decimal rate)
            : base(fname,lname,bvn, balance)
        {
            interestRate = rate;
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value > 0)
                    interestRate = value;
                else
                    throw new Exception("Interest rate must be greater than zero");
            }
        }


        public decimal CalculateInterest()
        {
            return AccountBalance * InterestRate;
        }
    }
}