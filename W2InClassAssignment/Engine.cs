namespace W2InClassAssignment;

public class Engine
{
    private double _horsePower;

    public double HorsePower
    {
        get => _horsePower;
        set => _horsePower = value;
    }

    public override string ToString()
    {
        return $"horsePower: {_horsePower}";
    }

    public Engine (double horsePower)
    {
        HorsePower = horsePower;
    }
}