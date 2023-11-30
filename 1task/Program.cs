using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

enum desire
{
    неучавствует,
    ленивый,
    желающий,
    учавствует
}
class Program
{

    static void Main()
    {
        string sfile = "studentiki.txt";
        List<Student> students = SRead(sfile);
        string[] events = { "настолки", "квиз", "лидер группы", "хакатон", "мистер и мисс ивмиит" };
        foreach (string e in events)
        {
            Events ee = new Events(e, new DateTime(2023, 11, 11, 17, 30, 00) , students, 5, "кукиш с маслом");
            ee.infoEvent(ee, e);
            ee.Listing_event(ee, students, e);
            ee.Islazy(students);
            ee.Choice(students);
        }
    }
    static List<Student> SRead(string filePath)
    {
        List<Student> students = new List<Student>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                if (data.Length == 2)
                {
                    string name = data[0];
                    string group = data[1];

                    students.Add(new Student(name, group));
                }
            }
        }

        return students;
    }
}
