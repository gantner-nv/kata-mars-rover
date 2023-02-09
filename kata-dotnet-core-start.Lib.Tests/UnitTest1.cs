namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Rover_Has_Default_Position()
    {
        //Act
        var result =  MarsRover.Create().CurrentPosition;
            
        //Assert
        Assert.Equal(result.X, 0);
        Assert.Equal(result.Y, 0);
    }
}