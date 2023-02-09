namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest
{
    [Fact]
    public void Rover_Has_Default_Position()
    {
        // Arrange
        var rover = MarsRover.Create();
        
        // Act
        var result =  rover.CurrentPosition;
            
        // Assert
        var expectedPosition = Position.Default;
        Assert.Equal(expectedPosition, result);
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