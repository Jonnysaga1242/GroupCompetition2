namespace USFLibrary;

public sealed class Book
{
    public string Title { get; }
    public string Author { get; }
    public string ISBN { get; }
    public int AvailableCopies { get; private set; }

    public Book(string title, string author, string isbn, int availableCopies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = availableCopies < 0 ? 0 : availableCopies;
    }

    public bool BorrowBook()
    {
        if (AvailableCopies <= 0) return false;
        AvailableCopies--;
        return true;
    }

    public void ReturnBook()
    {
        AvailableCopies++;
    }

    public override string ToString()
        => $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
}
