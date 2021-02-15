using System;

namespace OOP2LabaBankAccount
{
    enum AccountType {Checking, Deposit}
    class BankAccount
    {
        static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;
            Console.WriteLine(" goldAccount = {0},", goldAccount);
            Console.WriteLine(" platinumAccount = {0}", platinumAccount);
        }
    }
}
