namespace kata_dotnet_core_start.Lib;
public class MarsRover
{
    private MarsRover()
    {
        CurrentPosition = Position.Default;
    }
    
    public Position CurrentPosition { get; }

    public static MarsRover Create()
    {
        return new MarsRover();
    }

    public MarsRover MoveNorth()
    {
        CurrentPosition.Move("N");
        return this;
    }

    public MarsRover MoveSouth()
    {
        CurrentPosition.Move("S");
        return this;
    }
}
