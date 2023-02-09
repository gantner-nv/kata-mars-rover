namespace kata_dotnet_core_start.Lib;

public class Position: IEquatable<Position>
{
    private Position()
    {
        X = Axis.Zero;
        Y = Axis.Zero;
    }

    public Axis X { get; }

    public Axis Y { get; }

    public static Position Default => new Position();

    public void Move(string direction)
    {
        switch (direction)
        {
            case "N":
                X.Decrement();
                break;
            case "S":
                X.Increment();
                break;
            default:
                break;
        }
    }

    public bool Equals(Position? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return X.Equals(other.X) && Y.Equals(other.Y);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Position)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
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