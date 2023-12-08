public class Book {
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int CopiesAvailable { get; set; }

    public Book(string isbn, string title, string author, int copiesAvailable) {
        ISBN = isbn;
        Title = title;
        Author = author;
        CopiesAvailable = copiesAvailable;
    }

    public override string ToString() {
        return $"ISBN: {ISBN}, Title: {Title}, Author: {Author}, Copies Available: {CopiesAvailable}";
    }
}
