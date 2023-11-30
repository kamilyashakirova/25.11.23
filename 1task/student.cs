internal class Student
{
    internal string name { get; set; }
    internal string group { get; set; }
    internal desire desire { get; set; }
    internal bool id { get; set; }
    public Student(string name, string group)
    {
        this.name = name;
        this.group = group;
        this.desire = desire.неучавствует;
        id = false;

    }
}