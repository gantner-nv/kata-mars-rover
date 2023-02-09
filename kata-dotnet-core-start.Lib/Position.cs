namespace kata_dotnet_core_start.Lib;

public class Position
{
    private Position()
    {
        X = Axis.Zero;
        Y = Axis.Zero;
    }

    public Axis X { get; }

    public Axis Y { get; }

    public static Position Default => new Position();

    public void MoveNorth() => X.Decrement();
    
    public void MoveSouth() => X.Increment();
}

public class Axis : IEquatable<Axis>
{
    private int _value;
    
    private Axis(int value)
    {
        _value = value;
    }

    public void Increment() => _value++;
    
    
    public void Decrement() => _value--;

    public static Axis Zero => Axis.Create();

    public virtual bool Equals(Axis other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _value == other._value;
    }

    public static Axis Create(int value = 0) => new Axis(value);
}