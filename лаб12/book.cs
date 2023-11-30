public class book
{
    public string author { get; set; }
    public string title { get; set; }
    public string publisher { get; set; }
    public book(string title, string author, string publisher)
    {
        this.title = title;
        this.author = author;
        this.publisher = publisher;
    }
}

