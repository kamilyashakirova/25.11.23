using System;
using System.IO;

class Program
{
    static void Main()
    {
        //упражнение 11.1.
        Console.WriteLine("упражнение 11.1. создать новый класс, который будет являться фабрикой объектов класса банковский счет.");
        accountFactory factory = new accountFactory();
        account account1 = factory.CreateAcc(Atype.tecuschyi);
        account1.givememoney(2344);
        account1.PrintInfo();
        account account2 = factory.CreateAcc(28108427235, Atype.sberegatelnyi);
        account2.PrintInfo();
        account1.transfer(account2, 329);
        Console.WriteLine("банковский счёт 1 после перевода средств на 2-й счёт:");
        Console.WriteLine("баланс: {0}", account1.balance);
        account2.takemymoney(4523);
        Console.WriteLine("банковский счёт 2 после снятия денег:");
        Console.WriteLine("баланс: {0}", account2.balance);
        factory.CloseAcc(account1.number);
        Console.WriteLine("1-й счёт после закрытия:");
        account1.PrintInfo();
        Building building1 = Creator.CreateBuild(126, 13, 78, 6);
        Building building2 = Creator.CreateBuild(153, 18, 99, 9);
        Console.WriteLine("Домашнее задание 11.1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).\nЗдание номер {0}", building1.BuildingNumber);
        Console.WriteLine("Высота этажа: {0} м", building1.CalcHeight());
        Console.WriteLine("Количество квартир в подъезде: {0}", building1.CalcEntrance());
        Console.WriteLine("Количество квартир на этаже: {0}", building1.CalcFloor());
        Creator.RemoveBuilding(building1.BuildingNumber);
        accountFactory factory2 = new accountFactory();
        account ac1 = factory2.CreateAcc(1000, Atype.tecuschyi);
        account ac2 = factory2.CreateAcc(500, Atype.sberegatelnyi);
        Console.WriteLine("Account 1:");
        Console.WriteLine(ac2);

        Console.WriteLine("Account 2:");
        Console.WriteLine(ac2);

        Console.WriteLine("аккаунты совпадают: {0}", account1 == account2);
        Console.WriteLine("аккаунты не совпадают: {0}", account1 != account2);
    }
}
