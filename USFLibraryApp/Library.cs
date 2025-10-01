using System.Collections.Generic;
using System.Linq;

namespace USFLibrary;

public sealed class Library
{
    private readonly List<Book> _books = new();
    private readonly List<Person> _patrons = new();

    public void AddBook(Book book) => _books.Add(book);
    public void AddPatron(Person person) => _patrons.Add(person);

    public void DisplayBooks(string header = "Books in Library:")
    {
        System.Console.WriteLine(header);
        foreach (var b in _books)
            System.Console.WriteLine(b.ToString());
        System.Console.WriteLine();
    }

    public void DisplayPatrons(string header = "Patrons in Library:")
    {
        System.Console.WriteLine(header);
        foreach (var p in _patrons)
            System.Console.WriteLine(p.ToString());
        System.Console.WriteLine();
    }

    public Book? FindBookByTitle(string title) =>
        _books.FirstOrDefault(b => b.Title.Equals(title, System.StringComparison.OrdinalIgnoreCase));

    public Person? FindPatronByNameOrId(string key) =>
        _patrons.FirstOrDefault(p =>
            p.Name.Equals(key, System.StringComparison.OrdinalIgnoreCase) ||
            p.ID.Equals(key, System.StringComparison.OrdinalIgnoreCase));

    public string Borrow(string patronKey, string bookTitle)
    {
        var patron = FindPatronByNameOrId(patronKey);
        if (patron is null)
            return $"Patron '{patronKey}' not found.";

        var book = FindBookByTitle(bookTitle);
        if (book is null)
            return $"Book '{bookTitle}' not found.";

        if (!book.borrowable())
            return $"'{book.Title}' is not available.";

        book.BorrowBook();
        return $"{patron.Name} borrowed '{book.Title}'";
    }
}

// small extension for readability
file static class BookExtensions
{
    public static bool borrowable(this Book b) => b.AvailableCopies > 0;
}
