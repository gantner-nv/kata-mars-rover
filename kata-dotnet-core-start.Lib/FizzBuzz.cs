namespace kata_dotnet_core_start.Lib;
public class FizzBuzz
{
    public static string GetSearies(int number)
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
