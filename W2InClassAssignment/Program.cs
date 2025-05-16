namespace W2InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        // Point 
        Point p = new Point(1, 2);
        Point p2 = new Point(3, 4);
        Console.WriteLine(p.ToString());
        
        Console.WriteLine($" The distance between {p} and {p2} is {p.GetDistance(p2)}");
        Console.WriteLine("\n//////////////////\n");
        
        //Book
        Book b = new Book("Silmarillion", "J.R.R Tolkien", 1977);
        
        b.DisplayInfo();
        
        Console.WriteLine("\n//////////////////\n");
        
        //Student
        
        Student st = new Student(96,"Berk");
        Console.WriteLine(st.ToString());
        Console.WriteLine(st.IsPassing());
        
        Student st2 = new Student(46,"Al");
        Console.WriteLine(st2.ToString());
        Console.WriteLine(st2.IsPassing());
        
        Student st3 = new Student(-10,"No");
        Console.WriteLine(st3.ToString());
        Console.WriteLine(st3.IsPassing());
        
        Student st4 = new Student(50,"Barely");
        Console.WriteLine(st4.ToString());
        Console.WriteLine(st4.IsPassing());
        
        Console.WriteLine("\n//////////////////\n");
        
        // Engine
        
        Engine e = new Engine(102.8);
        
        Console.WriteLine(e.ToString());
        
        Console.WriteLine("\n//////////////////\n");
        
        // Car
        
        Car c = new Car(e,"Mercedes");
        Console.WriteLine(c.ToString());
        c.Describe();
        Console.WriteLine("\n//////////////////\n");

        static int CountVowels(string input)
        {
            char[] characters = input.ToCharArray();
            int count = 0;

            foreach (char c in characters)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            return count;
        }
        
         var a = CountVowels("aaa");
         Console.WriteLine(a.ToString());
    }
}