using System;
class Program
{
    static void Main(string[] args)
    {
        //упражнение 12.2.создать класс рациональных чисел
        Rational r1 = new Rational(56, 112);
        Rational r2 = new Rational(12, 72);
        Console.WriteLine(r1.ToString());
        Console.WriteLine(r2.ToString());
        Console.WriteLine("упражнение 12.2.создать класс рациональных чисел.\nr1 = {0}\nr2 = {1}", r1.ToString(), r2.ToString());
        Console.WriteLine("r1 == r2 : {2}", r1.ToString(), r2.ToString(), r1 == r2);
        Console.WriteLine("r1 > r2: {2}", r1.ToString(), r2.ToString(), r1 > r2);
        Console.WriteLine("r1 < r2: {2}", r1.ToString(), r2.ToString(), r1 < r2);
        Console.WriteLine("r1 <= r2:{2}", r1.ToString(), r2.ToString(), r1 <= r2);
        Console.WriteLine("r1 >= r2:{2}", r1.ToString(), r2.ToString(), r1 >= r2);
        Console.WriteLine("r1 + r2 = {2}", r1.ToString(), r2.ToString(), r1 + r2);
        Console.WriteLine("r1 - r2 = {2}", r1.ToString(), r2.ToString(), r1 - r2);
        Console.WriteLine("r1 * r2 = {2}", r1.ToString(), r2.ToString(), r1 * r2);
        Console.WriteLine("r1 / r2 = {2}", r1.ToString(), r2.ToString(), r1 / r2);
        Console.WriteLine("r1 % r2 = {2}", r1.ToString(), r2.ToString(), r1 % r2);
        Console.WriteLine("(float)r1:{0}\n(float)r2",(float)r1,(float)r2);
        Console.WriteLine("(int)r1:{0}\n(int)r2", (int)r1, (int)r2);
        //домашнее задание 12.1. описать класс комплексных чисел
        Complex k1 = new Complex(34, 77);
        Complex k2 = new Complex(-98, -87);
        Console.WriteLine("домашнее задание 12.1. описать класс комплексных чисел.\nk1 = {0}", k1.ToString());
        Console.WriteLine("k2 = {0}", k2.ToString());
        Console.WriteLine("k1 == k2: {0}", k1 == k2);
        Console.WriteLine("k1 != k2: {0}", k1 != k2);
        Complex summa = k1 + k2;
        Complex razn = k1 - k2;
        Complex proiz = k1 * k2;
        Console.WriteLine("k1 + k2 = {0}", summa);
        Console.WriteLine("k1 - k2 = {0}", razn);
        Console.WriteLine("k1 * k2 = {0}", proiz);
        //домашнее задание 12.2. написать делегат, с помощью которого реализуется сортировка книг
        book[] bs = new book[]
        {
            new book("\"десять негригят\"", "Агата Кристи", "ЭСКМО-АСТ"),
            new book("\"Бронепароходы\"", "Алексей Иванов", "Рипол Классик"),
            new book("\"Маленький принц\"", "Антуан де Сент-Экзюпери", "Эксмодетство"),
            new book("\"убийство в восточном экспрессе\"","Агата Кристи", "ЭСКМО-АСТ")
        };
        container container = new container(bs);
        container.Sort((b1, b2) => b1.publisher.CompareTo(b2.publisher));
        container.Sort((b1, b2) => b1.title.CompareTo(b2.title));
        container.Sort((b1, b2) => b1.author.CompareTo(b2.author));
        foreach (book b in bs)
        {
            Console.WriteLine("домашнее задание 12.2. написать делегат, с помощью которого реализуется сортировка книг\n{0} | {1} | {2}", b.title, b.author, b.publisher);
        }
    }
}