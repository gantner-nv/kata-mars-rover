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
    
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void Output_ShouldBe_Fizz_If_NumberIdOfModular_Of_3(int input)
    {
        // Act
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output , "FIZZ");
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Output_ShouldBe_Fizz_If_NumberIdOfModular_Of_5(int input)
    {
        // Act
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output , "BUZZ");
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void Output_ShouldBe_FizzBuzz_If_NumberIdOfModular_Of_3_or_5(int input)
    {
        // Act
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output , "FIZZBUZZ");
    }

    private string FizzBuzz(int i)
    {
        if (i % 5 == 0 && i % 3 == 0)
            return "FIZZBUZZ";
        
        if (i % 3 == 0)
            return "FIZZ";

        if (i % 5 == 0)
            return "BUZZ"; 
        
        return $"{i}";
    }
}