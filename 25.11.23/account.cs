using System;
using System.IO;

enum Atype
{
    tecuschyi,
    sberegatelnyi
}
class account
{   
    StreamWriter writer = new StreamWriter("account.txt"); 
    private static int accountnumber = 1;
    public int number { get; }
    public decimal balance { get; private set; }
    public Atype type { get; }
    private static int generate()
    {
        return accountnumber++;
    }
    internal account(Atype accountType)
    {
        number = generate();
        type = accountType;
        balance = 0;
    }

    internal account(decimal initialBalance, Atype accountType)
    {
        number = generate();
        type = accountType;
        balance = initialBalance;
    }
    internal bool takemymoney(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    internal void givememoney(decimal amount)
    {
        balance += amount;
    }

    internal void transfer(account destinationAccount, decimal amount)
    {
        if (amount <= balance)
        {
            takemymoney(amount);
            destinationAccount.givememoney(amount);
        }
        else
        {
            Console.WriteLine("нет денег!");
        }
    }
    internal void PrintInfo()
    {
        Console.WriteLine("номер счёта: " + accountnumber);
        Console.WriteLine("баланс: " + balance);
        Console.WriteLine("тип: " + type);
    }
    public void SaveFiles(string[] fs, string d)
    {
        string project = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        d = Path.Combine(project, d);

        if (!Directory.Exists(d))
        {
            Directory.CreateDirectory(d);
        }

        foreach (string f in fs)
        {
            string[] files = Directory.GetFiles(project, f);

            foreach (string file in files)
            {
                string destinationFilePath = Path.Combine(d, Path.GetFileName(file));
                File.Copy(file, destinationFilePath, true);
            }
        }
    }
}


