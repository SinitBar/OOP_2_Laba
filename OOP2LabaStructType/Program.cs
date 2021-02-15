using System;

namespace OOP2LabaStructType
{
    enum AccountType { Checking, Deposit }
    class BankAccountProgramm
    {
        public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;

        }
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 809201865015910;
            goldAccount.accBal = 10100100100100100100.35m;
            goldAccount.accType = AccountType.Checking;
            Console.WriteLine("Account number: {0}", goldAccount.accNo);
            Console.WriteLine("Account type: {0}", goldAccount.accType);
            Console.WriteLine("Account balance: {0:C2}", goldAccount.accBal);
        }
    }
}
