using System;
using System.IO;

enum Attype
{
    tecuschyi,
    sberegatelnyi
}
class account2
{
    private static int accountnumber = 1;
    public int number { get; }
    public decimal balance { get; private set; }
    public Attype type { get; }
    private static int generate()
    {
        return accountnumber++;
    }
    internal account2(Attype accountType)
    {
        number = generate();
        type = accountType;
        balance = 0;
    }

    internal account2(decimal initialBalance, Attype accountType)
    {
        number = generate();
        type = accountType;
        balance = initialBalance;
    }
    internal bool takemymoney2(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    internal void givememoney2(decimal amount)
    {
        balance += amount;
    }

    internal void transfer2(account2 destination, decimal amount)
    {
        if (amount <= balance)
        {
            takemymoney2(amount);
            destination.givememoney2(amount);
        }
        else
        {
            Console.WriteLine("нет денег!");
        }
    }
    public override int GetHashCode()
    {
        int h = 17;
        h = h * 23 + number.GetHashCode();
        h = h * 23 + balance.GetHashCode();
        h = h * 23 + type.GetHashCode();
        return h;
    }

    public override string ToString()
    {
        return $"Account Number: {number}\n" +
               $"Balance: {balance}\n" +
               $"Account Type: {type}";
    }
    public static bool operator ==(account2 account1, account2 account2)
    {
        if (ReferenceEquals(account1, null) && ReferenceEquals(account2, null))
        {
            return true;
        }

        if (ReferenceEquals(account1, null) || ReferenceEquals(account2, null))
        {
            return false;
        }

        return account1.Equals(account2);
    }

    public static bool operator !=(account2 account1, account2 account2)
    {
        return !(account1 == account2);
    }
    public void SaveFiles2(string[] fs, string d)
    {
        string project2 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        d = Path.Combine(project2, d);

        if (!Directory.Exists(d))
        {
            Directory.CreateDirectory(d);
        }

        foreach (string f in fs)
        {
            string[] files = Directory.GetFiles(project2, f);

            foreach (string file in files)
            {
                string destinationFilePath = Path.Combine(d, Path.GetFileName(file));
                File.Copy(file, destinationFilePath, true);
            }
        }

    }
}




