namespace W2InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        Point p = new Point(1, 2);
        var str = p.ToString();
        Console.WriteLine(str);
    }

    class Point
    {
        public int X;
        public int Y;


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            // use string interpolation to print Point
            return $"({X},{Y})";
        }
    }

}