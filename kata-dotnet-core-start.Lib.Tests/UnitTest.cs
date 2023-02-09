namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest
{
    [Fact]
    public void Rover_Has_Default_Position()
    {
        // Act
        var rover = MarsRover.Create();

        // Assert
        Assert.Equal(Position.Default, rover.CurrentPosition);
    }

    [Fact]
    public void Rover_Moved_Toward_North()
    {
        // Arrange
        var rover = MarsRover.Create();
        
        // Act
        var result =  rover.MoveNorth()!;
        
        // Assert
        Assert.Equal(Axis.Create(-1), result.CurrentPosition.X);
        Assert.Equal(Axis.Zero, result.CurrentPosition.Y);
    }

    [Fact]
    public void Rover_Moved_Toward_South()
    {
        // Arrange
        var rover = MarsRover.Create();
        
        // Act
        var result =  rover.MoveSouth();
        
        // Assert
        Assert.Equal(Axis.Create(1), result.CurrentPosition.X);
        Assert.Equal(Axis.Zero, result.CurrentPosition.Y);
    }
}