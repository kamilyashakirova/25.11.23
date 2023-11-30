using System;
using System.Collections.Generic;

public class accountFactory2
{
    private Dictionary<int, account2> accounts2;

    internal accountFactory2()
    {
        accounts2 = new Dictionary<int, account2>();
    }

    internal account2 CreateAcc(Attype accountType)
    {
        account2 account2 = new account2(accountType);
        accounts2.Add(account2.number, account2);
        return account2;
    }

    internal account2 CreateAcc(decimal balance, Attype accountType)
    {
        account2 account2 = new account2(balance, accountType);
        accounts2.Add(account2.number, account2);
        return account2;
    }

    internal void CloseAcc(int number)
    {
        if (accounts2.ContainsKey(number))
        {
            accounts2.Remove(number);
            Console.WriteLine("банковский счёт номер {0} закрылся", number);
        }
        else
        {
            Console.WriteLine("банковский счёт номер {0} не существует", number);
        }
    }

}

