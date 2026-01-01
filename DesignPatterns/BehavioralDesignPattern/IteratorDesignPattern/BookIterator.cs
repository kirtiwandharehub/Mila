public class BookIterator : IIterator<Book>
{
    private Library library;
    private int currentIndex;

    public BookIterator(Library library)
    {
        this.library = library;
        currentIndex = -1;
    }

    public bool MoveNext()
    {
        if (currentIndex < library.Count - 1)
        {
            currentIndex++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset() => currentIndex = -1;

    public Book Current
    {
        get
        {
            if (currentIndex >= 0 && currentIndex < library.Count)
                return library.GetBook(currentIndex);
            else    
                return null;
        }
    }
}