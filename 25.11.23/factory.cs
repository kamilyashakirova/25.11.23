using System;
using System.Collections.Generic;

public class accountFactory
{
    private Dictionary<int, account> accounts;

    internal accountFactory()
    {
        accounts = new Dictionary<int, account>();
    }

    internal account CreateAcc(Atype accountType)
    {
        account account = new account(accountType);
        accounts.Add(account.number, account);
        return account;
    }

    internal account CreateAcc(decimal balance, Atype accountType)
    {
        account account = new account(balance, accountType);
        accounts.Add(account.number, account);
        return account;
    }

    internal void CloseAcc(int number)
    {
        if (accounts.ContainsKey(number))
        {
            accounts.Remove(number);
            Console.WriteLine("банковский счёт номер {0} закрылся", number);
        }
        else
        {
            Console.WriteLine("банковский счёт номер {0} не существует", number);
        }
    }

}
