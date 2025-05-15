using System.Runtime.InteropServices.JavaScript;

namespace W2InClassAssignment;

public class Book
{
    public string Name;
    public string Author;
    public int YearPublished;

    public Book(string name, string author, int yearPublished)
    {
        Name = name;
        Author = author;
        YearPublished = yearPublished;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"""
                           Title: {Name}
                           Author: {Author}
                           Year Published: {YearPublished}
                           """);
    }
}