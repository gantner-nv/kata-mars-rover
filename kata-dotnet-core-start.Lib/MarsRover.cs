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
}

public class Position
{
    private Position()
    {
        
    }
    public int X { get; set; }

    public int Y { get; set; }

    public static Position Default => new Position();

}
