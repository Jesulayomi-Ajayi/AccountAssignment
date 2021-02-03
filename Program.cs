using System;

namespace AccountAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Account johnAccount = new Account("John", "Peter", "1234567890", 5000M);
            SavingsAccount andrewSavingsAccount = new SavingsAccount("Andrew", "James", "0123456789", 50000M, 0.2M);
            CheckingAccount mohammedCheckingAccount = new CheckingAccount("Mohammed", "Rufus", "2343546565", 100000M, 65M);

            johnAccount.Credit(1500M);
            Console.WriteLine(johnAccount.AccountBalance);
            johnAccount.Debit(300M);
            Console.WriteLine(johnAccount.AccountBalance);
            Console.WriteLine();

            decimal interest = andrewSavingsAccount.CalculateInterest();
            andrewSavingsAccount.Credit(interest);
            Console.WriteLine(andrewSavingsAccount.AccountBalance);
            Console.WriteLine();

            mohammedCheckingAccount.Credit(20000M);
            Console.WriteLine(mohammedCheckingAccount.AccountBalance);
            mohammedCheckingAccount.Debit(50000M);
            Console.WriteLine(mohammedCheckingAccount.AccountBalance);
            

            
        }
    }
}
