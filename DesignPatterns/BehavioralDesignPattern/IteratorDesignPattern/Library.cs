using System.Collections.Concurrent;

public class Library : IAggregate<Book>
{
    private List<Book> books;

    public Library(List<Book> books)
    {
        this.books = books;
    }

    public IIterator<Book> CreateIterator()
    {
        return new BookIterator(this);
    }

    public int Count => books.Count;

    public Book GetBook(int index)
    {
        if (index >= 0 && index < books.Count)
            return books.ElementAt(index);
        else
            return null;
    }
}