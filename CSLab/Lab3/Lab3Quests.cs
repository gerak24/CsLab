namespace CSLab.Lab3;

public abstract class Lab3Quests
{
    protected static void EvenCheck()
    {
        var results = MultiplicityAnalyze(1, 100, 2);
        foreach (var result in results)
            Console.Write($"{result} ");
        Console.WriteLine();
        Console.WriteLine($"Сумма чётных чисел = {results.Sum()}");
        Console.WriteLine($"Количество чётных чисел = {results.Count}");
    }

    protected static List<int> EndCharAnalyze(char ends)
    {
        var success = false;
        int from = 0, to = 0;
        while (!success)
        {
            Console.WriteLine("Введите начало промежутка");
            success = int.TryParse(Console.ReadLine(), out from);
            if (!success)
                Console.WriteLine("Промежуток должен быть задан целым числом.");
            Console.WriteLine("Введите конец промежутка");
            success = int.TryParse(Console.ReadLine(), out to);
            if (!success)
                Console.WriteLine("Промежуток должен быть задан целым числом.");
        }

        var results = new List<int>();
        for (var i = from; i <= to; i++)
        {
            if (i.ToString().Last() == ends)
                results.Add(i);
        }
        return results;
    }

    private static List<int> MultiplicityAnalyze(int from, int to, int multyplier)
    {
        List<int> results = [];
        for (var i = from; i <= to; i++)
        {
            if (i % multyplier != 0) continue;
            results.Add(i);
        }

        return results;
    }
}