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
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void Output_ShouldBe_Fizz_If_NumberIsModular_Of_3_And_Not_Contains_3(int input)
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
    public void Output_ShouldBe_Fizz_If_NumberIsModular_Of_5_And_Not_Contains_5(int input)
    {
        // Act
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output , "BUZZ");
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(45)]
    public void Output_ShouldBe_FizzBuzz_If_NumberIdOfModular_Of_3_or_5(int input)
    {
        // Act
        var output = FizzBuzz(input);

        // Assert
        Assert.Equal(output , "FIZZBUZZ");
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
    
    private string FizzBuzz(int i)
    {
        var output = new List<string>();
        
        // if (i.ToString().Contains("3"))
        //     output.Add( "FIZZ");
        
        if (i % 3 == 0)
            output.Add( "FIZZ"); 

        if (i % 5 == 0)
            output.Add( "BUZZ"); 
        
        if(output.Any())
            return string.Join(string.Empty, output);
        
        return $"{i}";
    }
}