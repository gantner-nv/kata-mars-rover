// See https://aka.ms/new-console-template for more information

using kata_dotnet_core_start.Lib;

Console.WriteLine("Hello, World!");
PrintNumber();

public partial class Program
{
    public static void PrintNumber()
    {
        var range = Enumerable.Range(1, 100);
        foreach (var number in range)
            Console.WriteLine(FizzBuzz.GetSearies(number));
    }

    
}