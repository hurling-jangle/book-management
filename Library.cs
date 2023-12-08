using System;
using System.Collections.Generic;

public class Library {
    private List<Book> books;

    public Library() {
        books = new List<Book>();
    }

    public void AddBook(Book book) {
        books.Add(book);
    }

    public void DisplayBooks() {
        foreach (var book in books) {
            Console.WriteLine(book);
        }
    }

    public bool BorrowBook(Book book, User user) {
        if (book.CopiesAvailable > 0) {
            book.CopiesAvailable--;
            Console.WriteLine($"{user.Username} borrowed {book.Title}");
            return true;
        } else {
            Console.WriteLine($"Sorry, no copies of {book.Title} available for borrowing.");
            return false;
        }
    }
}
