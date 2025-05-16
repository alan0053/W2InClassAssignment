namespace W2InClassAssignment;

public class Car
{
    private Engine _engine;
    
    private string _model;


    public Engine Engine
    {
        get => _engine;
        
        set => _engine = value;
    }

    public string Model
    {
        get => _model;
        
        set => _model = value;
        
    }

    public Car(Engine engine, string model)
    {
        Engine = engine;
        
        Model = model;
    }

    public override string ToString()
    {
        return $"{Model} - {Engine}";
    }

    public void Describe()
    {
        Console.WriteLine($"""
                           Model:{Model}
                           Engine Horsepower:{Engine.HorsePower} 
                           """);
    }
}