namespace W2InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        // Point 
        Point p = new Point(1, 2);
        Console.WriteLine(p.ToString());
        
        //Book
        Book b = new Book("Silmarillion", "J.R.R Tolkien", 1977);
        
        b.DisplayInfo();
    }
}