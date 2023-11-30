using System;
public class container
{
    private book[] books;
    public container(book[] books)
    {
        this.books = books;
    }
    public void Sort(Comparison<book> c)
    {
        Array.Sort(books, c);
    }
}