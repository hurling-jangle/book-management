class Program {
    static void Main() {
        User user = new User("john_doe", "password123");
        Book book1 = new Book("123456", "The Catcher in the Rye", "J.D. Salinger", 5);
        Book book2 = new Book("789012", "To Kill a Mockingbird", "Harper Lee", 3);

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("Library Books:");
        library.DisplayBooks();

        Console.WriteLine("\nUser Authentication:");
        if (user.Authenticate("password123")) {
            Console.WriteLine($"{user.Username} authenticated successfully.");
        } else {
            Console.WriteLine("Authentication failed.");
        }

        Console.WriteLine("\nBorrowing Books:");
        library.BorrowBook(book1, user);
        library.BorrowBook(book2, user);
        library.BorrowBook(book2, user); // Attempting to borrow an unavailable book

        Console.WriteLine("\nUpdated Library Books:");
        library.DisplayBooks();
    }
}
