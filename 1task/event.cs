using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

internal class Events
    {
        internal string name { get; set; }
        internal DateTime time { get; set; }
        internal List<Student> students { get; set; }
        internal int cntstud { get; set; }
        internal string prize { get; set; }
        public Events(string name, DateTime time, List<Student> students, int cntstud, string prize)
        {
            this.name = name;
            this.time = time;
            this.students = students;
            this.cntstud = cntstud;
            this.prize = prize;
        }
        public void infoEvent(Events events, string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine("мероприятие: {0} на {1}", events.name, time);
            }
            Console.WriteLine("мероприятие: {0} на {1}", events.name, time);
        }
        public string[] Listing_event(Events events, List<Student> students, string file)
        {;
            int[] a = new int[events.cntstud];
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < events.cntstud; i++)
            {
                int count = random.Next(0, 51);
                if (!a.Contains(count))
                {
                    a[i] += count;
                    using (StreamWriter writer = new StreamWriter(file, true))
                    {
                        writer.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);
                    }
                    Console.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);
                }
                else
                {
                    count = random.Next(0, events.cntstud);
                    if (!a.Contains(count))
                    {
                        a[i] += count;
                        using (StreamWriter writer = new StreamWriter(file, true))
                        {
                            writer.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);
                        }
                        Console.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);
                    }
                    else
                    {
                        count = random.Next(0, events.cntstud);
                        if (!a.Contains(count))
                        {
                            a[i] += count;
                            using (StreamWriter writer = new StreamWriter(file, true))
                            {
                                writer.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);
                            }
                            Console.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);
                        }
                        else
                        {
                            using (StreamWriter writer = new StreamWriter(file, true))
                            {
                                writer.WriteLine($"Участник не нашёлся");
                            }                        
                            Console.WriteLine("Участник: {0}, группа: {1}", students[count].name, students[count].group);

                    }
                    }
                }
                students[count].desire = desire.учавствует;
            }
            string[] sp = new string[a.Length + 1];
            string[] s = new string[1];
            s[0] = "отмена розыгрыша, пришли чуваки только из одной группы";
            string[] cnt = new string[1];
            for (int i = 0;i < a.Length ; i++)
            {
                sp[i] = students[a[i]].group;
            }
            if (sp.Contains("09-321"))
            {
                if (sp.Contains("09-322"))
                {
                    cnt[0] = $"В {events.time} пройдет розыгрыш на {events.prize}";
                    s = new string[a.Length + 1];

                    for (int i = 0; a.Length > i; i++)
                    {
                        s[i] += $"Участник: {students[a[i]].name}, группа: {students[a[i]].group}";
                    }
                    string[] res = cnt.Concat(s).ToArray();
                    return res;
                }
                else
                {
                    return s;
                }
            }
            else
            {
                return s;
            }
        }
        public void Islazy(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].desire == desire.неучавствует)
                {
                    students[i].desire = desire.ленивый;
                    Console.WriteLine("студент {0} из группы {1} ленивая задница", students[i].name, students[i].group);
                }
            }
        }
        public void Choice(List<Student> students)
        {
            Random random = new Random();
            for (int i = 0; i < students.Count; i++)
            {
                if (random.Next(0, 51) > 12)
                {
                    students[i].desire = desire.желающий;
                    Console.WriteLine("студенту: {0} из группы{1}, видимо, нечего делать, но он хочет пойти на мероприятие", students[i].name, students[i].group);
                }
            }
        }

    }