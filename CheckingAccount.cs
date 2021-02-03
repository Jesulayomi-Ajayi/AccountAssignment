using System;

namespace AccountAssignment
{
    public class CheckingAccount : Account
    {
        private decimal transactionFee;

        public CheckingAccount(string fname, string lname, string bvn, decimal balance, decimal fee)
            :base(fname,lname,bvn, balance)
        {
            TransactionFee = fee;
        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                if(value > 0)
                    transactionFee = value;
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            AccountBalance = AccountBalance - TransactionFee;
        }

        public override bool Debit(decimal amount)
        {
            bool IsSuccessful;
            IsSuccessful = base.Debit(amount);
            if(IsSuccessful == true)
            {
                AccountBalance = AccountBalance - TransactionFee;
                return true;
            }
            
            else
            {
                Console.WriteLine("Transaction unsuccessful");
                return false;
            }
        }
    }
}