namespace W2InClassAssignment;

public class Point
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

    public double GetDistance(Point other)
    {
       return  Math.Sqrt((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y));
      
    }
}
