namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Given_NumberIsNotMultiple_Of_3_And_5_Then_Output_Is_SameNumber(int input)
    {
        // Act
        var output = FizzBuzz(input);

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
        var output = FizzBuzz(input);

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
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output, "BUZZ");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(45)]
    public void Given_NumberIsMultiple_Of_3_And_5_Then_Output_Is_FIZZBUZZ(int input)
    {
        // Act
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output, "FIZZBUZZ");
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(11, "11")]
    [InlineData(6, "FIZZ")]
    [InlineData(9, "FIZZ")]
    [InlineData(12, "FIZZ")]
    [InlineData(5, "BUZZ")]
    [InlineData(10, "BUZZ")]
    [InlineData(20, "BUZZ")]
    [InlineData(15, "FIZZBUZZ")]
    [InlineData(45, "FIZZBUZZ")]
    public void Given_NumberWithExpectedOutput_Then_Result_Is_Matched(int number, string expected)
    {
        var output = FizzBuzz(number);
        Assert.Equal(output, expected);
    }

    // [Fact]
    // public void Output_Should_Fizz_If_NumberContains_3()
    // {
    //     // Act
    //     var output = FizzBuzz(13);
    //     
    //     // Assert
    //     Assert.Equal(output, "FIZZ");
    // }
    //  
    // [Fact]
    // public void Output_Should_Fizz_If_NumberContains_3_and_DevideBy3()
    // {
    //     // Act
    //     var output = FizzBuzz(3);
    //     
    //     // Assert
    //     Assert.Equal(output, "FIZZFIZZ");
    // }

    private string FizzBuzz(int number)
    {
        var output = new List<string>();

        // if (i.ToString().Contains("3"))
        //     output.Add( "FIZZ");

        if (IsMultipleOf3(number))
            output.Add("FIZZ");

        if (IsMultipleOf5(number))
            output.Add("BUZZ");

        if (output.Any())
            return string.Join(string.Empty, output);

        return $"{number}";
    }

    private static bool IsMultipleOf5(int number)
    {
        return number % 5 == 0;
    }

    private static bool IsMultipleOf3(int number)
    {
        return number % 3 == 0;
    }
}