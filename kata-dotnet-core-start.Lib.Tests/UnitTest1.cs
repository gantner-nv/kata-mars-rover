namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Given_NumberIsNotMultiple_Of_3_And_5_Then_Output_Is_SameNumber(int input)
    {
        // Act
        var output = FizzBuzz.GetSearies(input);

        // Assert
        Assert.Equal(output, input.ToString());
    }

    [Theory]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void Given_NumberIsMultiple_Of_3_Then_Output_Is_FIZZ(int input)
    {
        // Act
        var output = FizzBuzz.GetSearies(input);

        // Assert
        Assert.Equal(output, "FIZZ");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Given_NumberIsMultiple_Of_5_Then_Output_Is_BUZZ(int input)
    {
        // Act
        var output = FizzBuzz.GetSearies(input);

        // Assert
        Assert.Equal(output, "BUZZ");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(45)]
    public void Given_NumberIsMultiple_Of_3_And_5_Then_Output_Is_FIZZBUZZ(int input)
    {
        // Act
        var output = FizzBuzz.GetSearies(input);

        // Assert
        Assert.Equal(output, "FIZZBUZZ");
    }
}