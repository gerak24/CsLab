using static System.Console;

namespace CSLab.Shared;

// ReSharper disable once InconsistentNaming
public static class SharedFunctions
{
    public static int EnterInt(string text)
    {
        var success = false;
        var num = 0;
        while (!success)
        {
            WriteLine(text);
            success = int.TryParse(ReadLine(), out num);
        }

        return num;
    }

    public static double EnterDouble(string text)
    {
        var success = false;
        var num = 0;
        while (!success)
        {
            WriteLine(text);
            success = int.TryParse(ReadLine(), out num);
        }

        return num;
    }

    public static void PrintArray<T>(IEnumerable<T> array, string? description = null, bool lined = false)
    {
        if (description != null) WriteLine($"{description}:");
        foreach (var i in array)
            if (lined)
                WriteLine($"{i}");
            else
            {
                Write($"{i}, ");
                WriteLine();
            }
    }
}