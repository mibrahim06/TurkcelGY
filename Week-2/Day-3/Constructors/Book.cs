namespace Constructors;

/**
 * This class represents a book
 * Brief description: This class shows how to use constructors to initialize the data of a class
 */
public class Book
{
    private string title;
    private string author;
    private int pages;
    private int year;
    private string publisher;
    private string isbn;
    private string language;
    
    // Default constructor
    public Book()
    {
        title = "No title";
        author = "No author";
        pages = 0;
        year = 0;
        publisher = "No publisher";
        isbn = "No ISBN";
        language = "No language";
    }
    
    // Constructor with parameters
    public Book(string title, string author, int pages, int year, string publisher, string isbn, string language)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
        this.year = year;
        this.publisher = publisher;
        this.isbn = isbn;
        this.language = language;
    }
    
    // Getters and setters
    public string GetTitle()
    {
        return title;
    }
    
    public void SetTitle(string title)
    {
        this.title = title;
    }
    
    public string GetAuthor()
    {
        return author;
    }
    
    public void SetAuthor(string author)
    {
        this.author = author;
    }
    
    public int GetPages()
    {
        return pages;
    }
    
    public void SetPages(int pages)
    {
        this.pages = pages;
    }
    
    public int GetYear()
    {
        return year;
    }
    
    public void SetYear(int year)
    {
        this.year = year;
    }
    
    public string GetPublisher()
    {
        return publisher;
    }
    
    public void SetPublisher(string publisher)
    {
        this.publisher = publisher;
    }
    
    public string GetIsbn()
    {
        return isbn;
    }
    
    public void SetIsbn(string isbn)
    {
        this.isbn = isbn;
    }
    
    public string GetLanguage()
    {
        return language;
    }
    
    public void SetLanguage(string language)
    {
        this.language = language;
    }
    
    // Print method
    public void PrintBook()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Pages: {pages}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Publisher: {publisher}");
        Console.WriteLine($"ISBN: {isbn}");
        Console.WriteLine($"Language: {language}");
    }
}
