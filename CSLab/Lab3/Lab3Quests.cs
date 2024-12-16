namespace CSLab.Lab3;

public abstract class Lab3Quests
{
    protected static List<int> EnterNums()
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

        return [from, to];
    }

    protected static int EnterNum(string text)
    {
        var success = false;
        var num = 0;
        while (!success)
        {
            Console.WriteLine(text);
            success = int.TryParse(Console.ReadLine(), out num);
        }

        return num;
    }

    protected static List<int> EndCharAnalyze(char ends)
    {
        var nums = EnterNums();
        var from = nums[0];
        var to = nums[1];
        var results = new List<int>();
        for (var i = from; i <= to; i++)
        {
            if (i.ToString().Last() == ends)
                results.Add(i);
        }

        return results;
    }

    protected static List<int> MultiplicityAnalyze(List<int> nums, int multyplier)
    {
        var from = nums[0];
        var to = nums[1];
        List<int> results = [];
        for (var i = from; i <= to; i++)
        {
            if (i % multyplier != 0) continue;
            results.Add(i);
        }

        return results;
    }

    protected static bool EasyNum(int num)
    {
        if (num is <= 1 and >= -1) return false;
        for (var i = 2; i < int.Abs(num); i++)
        {
            if (num % i != 0) continue;
            return false;
        }

        return true;
    }

    protected static void EasyNums()
    {
        var nums = EnterNums();
        var from = nums[0];
        var to = nums[1];
        for (var i = from; i < to; i++)
        {
            if (EasyNum(i)) Console.Write($"{i} ");
        }

        Console.WriteLine();
    }

    protected static void Guessing()
    {
        while (true)
        {
            var num = Random.Shared.Next(0, 100);
            var pointer = EnterNum("Введите число: ");
            while (pointer != num)
            {
                Console.WriteLine(pointer > num ? "Перелёт!" : "Недолёт!");
                pointer = EnterNum("Введите число: ");
            }

            Console.WriteLine("Молодец! В точку!");
            Console.WriteLine("Начать заново? Y\\N");
            var qqpoint = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (qqpoint != 'Y' && qqpoint != 'N' && qqpoint != 'y' && qqpoint != 'n')
            {
                Console.WriteLine("Начать заново? Y\\N");
                qqpoint = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            switch (qqpoint)
            {
                case 'Y' or 'y':
                    continue;
                case 'N' or 'n':
                    return;
            }

            break;
        }
    }

    protected static void MultyTrainer()
    {
        int count = 0, right = 0;
        while (true)
        {
            var first = Random.Shared.Next(1, 9);
            var second = Random.Shared.Next(1, 9);
            Console.WriteLine($"{first}*{second} = ");
            var num = EnterNum("Введите число: ");
            count++;
            if (num == first * second)
            {
                right++;
                Console.WriteLine("Верно");
            }
            else
                Console.WriteLine("Неверно");

            Console.WriteLine("Продолжить? Y\\N");
            var qqpoint = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (qqpoint != 'Y' && qqpoint != 'N' && qqpoint != 'y' && qqpoint != 'n')
            {
                Console.WriteLine("Продолжить? Y\\N");
                qqpoint = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            switch (qqpoint)
            {
                case 'Y' or 'y':
                    continue;
                case 'N' or 'n':
                    Console.WriteLine($"Всего попыток – {count}");
                    Console.WriteLine($"Верных ответов – {right} ({Math.Round((decimal)right / count * 100)})%");
                    Console.WriteLine(
                        $"Неверных – {count - right} ({Math.Round(100 - (decimal)right / count * 100)}%).");
                    return;
            }
        }
    }

    protected static void PercentCalc()
    {
        double sum = EnterNum("Введите сумму вклада: ");
        var months = EnterNum("Введите количество месяцев: ");
        for (var i = 0; i < months; i++)
        {
            sum += sum * 0.02;
        }

        Console.WriteLine($"Сумма на счету к концу срока: {sum}");
    }

    protected static void MultyTable()
    {
        for (var first = 1; first < 10; first++)
        {
            for (var second = 1; second < 10; second++)
            {
                Console.Write($"{first * second} ");
            }
            Console.WriteLine();
        }
    }
}