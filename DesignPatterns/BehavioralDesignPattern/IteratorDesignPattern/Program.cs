List<Book> books = new List<Book>()
    {
        new Book() {Title = "Paw Patrol"},
        new Book() {Title = "Star Wars"},
        new Book() {Title = "Mickey Mouse"}
    };

Library library= new Library(books);
IIterator<Book> bookIterator= library.CreateIterator();
Console.WriteLine("----First iteration------------");
while(bookIterator.MoveNext())
{
    Console.WriteLine(bookIterator.Current.Title);
}

Console.WriteLine("----Second iteration------------");
bookIterator.Reset();
while(bookIterator.MoveNext())
{
    Console.WriteLine(bookIterator.Current.Title);
}
