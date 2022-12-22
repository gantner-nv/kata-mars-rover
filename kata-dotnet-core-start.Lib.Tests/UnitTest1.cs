namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Output_ShouldBe_SameAsInput()
    {
        // Act
        var output = FizzBuzz(1);

        // Assert
        Assert.Equal(output , "1");
    }
    
    [Fact]
    public void Output_ShouldBe_SameAsInput_2()
    {
        // Act
        var output = FizzBuzz(2);

        // Assert
        Assert.Equal(output , "2");
    }

    private string FizzBuzz(int i)
    {
        return $"{i}";
    }
}