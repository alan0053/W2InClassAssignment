namespace W2InClassAssignment;

public class Student
{
    private double _grade;
    
    private string _studentName;

    public double Grade
    {
        get => _grade;

        set
        {
            if (value is >= 0 and <= 100)
            {
                _grade = value; 
            }
        }
    }

    public string StudentName
    {
        get => _studentName;

        set => _studentName = value;
    }

    public Student(int grade, string studentName)
    {
        Grade = grade;
        StudentName = studentName;
    }

    public bool IsPassing()
    {
        return Grade >= 50;
    }

    public override string ToString()
    {
        return $"Name: {StudentName}, Grade: {Grade}";
    }
    
    
}