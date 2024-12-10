using static System.Int32;

namespace CSLab.Lab2;

public abstract class Lab2Quests
{
    protected static void Multiplicity(int brief)
    {
        var success = false;
        var digits = 0;
        while (!success)
        {
            Console.WriteLine("Введите число:");
            success = TryParse(Console.ReadLine(), out digits);
        }

        Console.WriteLine(digits % brief == 0 ? $"Число кратно {brief}" : $"Число не кратно {brief}");
    }

    protected static void NumAnalyze()
    {
        var success = false;
        var digits = 0;
        while (!success)
        {
            Console.WriteLine("Введите число:");
            success = TryParse(Console.ReadLine(), out digits);
        }

        if (digits.ToString().Length == 2 && digits.ToString().Last() == '3')
            Console.WriteLine("Это двузначное число, оканчивающееся на 3");
        else
            Console.WriteLine("Это не двузначное число, или оно не оканчивается на 3");
    }

    protected static void BankPercent()
    {
        Console.WriteLine("Вклад < 100 — 5%");
        Console.WriteLine("Вклад > 100 но < 200 — 7%");
        Console.WriteLine("Вклад > 200 — 10%");
        var success = false;
        var sum = 0;
        while (!success)
        {
            Console.WriteLine("Введите сумму вклада:");
            success = TryParse(Console.ReadLine(), out sum);
        }

        var percent = sum < 100 ? 0.05 : sum < 200 ? 0.07 : 0.10;
        Console.WriteLine($"Процент начисления: {percent * 100}");
        Console.WriteLine($"Сумма начисления: {Math.Round(sum * percent)}");
        Console.WriteLine($"Итоговая сумма: {Math.Round(sum + sum * percent)}");
    }

    protected static void QuadraticEquations()
    {
        while (true)
        {
            Console.WriteLine("Выберите, корни какого уравнения хотите найти:");
            Console.WriteLine("1: 4x^2-4x+1=0");
            Console.WriteLine("2: x^2+2x-48=0");
            Console.WriteLine("3: x^2+2x+5=0");
            var pointer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            var dicr = 0;
            switch (pointer)
            {
                case '1':
                    Console.WriteLine($"D = 4^2-4*4*1 = 16-16 = {dicr}");
                    Console.WriteLine("x1,2 = (4+√D)/2*4 = 4/8 = 0,5");
                    return;
                case '2':
                    Console.WriteLine("D = 2^2-4*1*(-48) = 4 + 192 = 196");
                    dicr = 2 * 2 + -4 * -48;
                    Console.WriteLine($"x1 = (-2+√D)/2 = -2 + {Math.Sqrt(dicr)}/2 = {(-2 + Math.Sqrt(dicr)) / 2}");
                    Console.WriteLine($"x2 = (-2+√D)/2 = -2 - {Math.Sqrt(dicr)}/2 = {(-2 - Math.Sqrt(dicr)) / 2}");
                    return;
                case '3':
                    Console.WriteLine("D = 2^2 - 4*1*5 = 4-20 = -16");
                    Console.WriteLine("Так как D < 0 действительных корней нет");
                    return;
                default:
                    Console.WriteLine("Нужно указать цифру от 1 до 3");
                    continue;
            }
        }
    }

    protected static void DayOfWeek()
    {
        var success = false;
        var day = 0;
        while (!success)
        {
            Console.WriteLine("Введите число 1-7:");
            success = TryParse(Console.ReadLine(), out day);
            if (day <= 7) continue;
            Console.WriteLine("Такого дня недели не существует");
            success = false;
        }

        Console.WriteLine(DateOnly.FromDayNumber(day - 1).DayOfWeek);
    }

    protected static void RandMath()
    {
        var first = Random.Shared.Next(1, 9);
        var second = Random.Shared.Next(1, 9);
        Console.WriteLine($"{first}*{second} = ");
        var success = false;
        var result = 0;
        while (!success)
        {
            success = TryParse(Console.ReadLine(), out result);
            if (!success)
                Console.WriteLine("Ответом должно быть целое число.");
        }

        Console.WriteLine(result == first * second ? "Верно." : "Неверно.");
    }

    protected static void CargoRaces()
    {
        var success = false;
        int v1, v2, t1, t2;
        while (!success)
        {
            Console.WriteLine("В одну сторону выезжают 2 грузовика.");
            Console.Write("Первый выехал со скоростью ");
            success = TryParse(Console.ReadLine(), out v1);
            if (!success)
                continue;
            Console.Write("Через ");
            success = TryParse(Console.ReadLine(), out t1);
            if (!success)
                continue;
            Console.Write("Выехал второй грузовик со скоростью ");
            success = TryParse(Console.ReadLine(), out v2);
            if (!success)
                continue;
            Console.Write("И через ");
            success = TryParse(Console.ReadLine(), out t2);
            Console.WriteLine(v1 * t1 <= v2 * t2
                ? "Второй грузовик догонит первый"
                : "Второй грузовик не догонит первый");
        }
    }

    protected static void SystemOfFunctions()
    {
        var success = false;
        var x = 0;
        while (!success)
        {
            Console.WriteLine("Введите x:");
            success = TryParse(Console.ReadLine(), out x);
        }

        switch (x)
        {
            case > 0:
                Console.WriteLine($"y = -2x+1 = {-2 * x + 1}");
                break;
            case 0:
                Console.WriteLine("y = 0");
                break;
            default:
                Console.WriteLine($"y = 3*|x|-1 = {3 * Math.Abs(x) - 1}");
                break;
        }
    }

    protected static double Discount()
    {
        var success = false;
        var sum = 0;
        while (!success)
        {
            Console.WriteLine("Введите сумму покупки:");
            success = TryParse(Console.ReadLine(), out sum);
        }

        double percent = 0;
        percent = sum switch
        {
            < 18000 => 0.01,
            < 30000 => 0.05,
            > 40000 => 0.1,
            _ => percent
        };
        var discount = Math.Round(sum * percent);
        Console.WriteLine($"Процент скидки: {percent}");
        Console.WriteLine($"Сумма скидки: {discount}");
        return Math.Round(sum - discount);
    }

    protected static double Discount(char rate)
    {
        Console.WriteLine();
        var success = false;
        var ratenum = 0;
        while (!success)
        {
            success = TryParse(rate.ToString(), out ratenum);
            if (success && ratenum <= 5) continue;
            Console.WriteLine("Рейтинг покупателя должен быть целым числом от 0 до 5.");
            Console.WriteLine("Введите рейтинг покупателя:");
            rate = Console.ReadKey().KeyChar;
            Console.WriteLine();
            success = false;
        }

        var result = Discount();
        var ratedisc = ratenum switch
        {
            0 => 0,
            1 => 200,
            2 => 400,
            3 => 600,
            4 => 700,
            5 => 800,
            _ => 0
        };
        Console.WriteLine($"Скидка за рейтинг покупателя - {ratedisc}");
        return Math.Round(result - ratedisc);
    }
}