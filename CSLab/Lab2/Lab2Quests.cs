using CSLab.Shared;

namespace CSLab.Lab2;

public class Lab2Quests
{
    protected static void Multiplicity(int brief)
    {
        var digits = SharedFunctions.EnterInt("Введите число:");
        Console.WriteLine(digits % brief == 0 ? $"Число кратно {brief}" : $"Число не кратно {brief}");
    }

    protected static void NumAnalyze()
    {
        var digits = SharedFunctions.EnterInt("Введите число:");

        if (digits.ToString().Length == 2 && digits.ToString().Last() == '3')
            Console.WriteLine("Это двузначное число, оканчивающееся на 3");
        else
            Console.WriteLine("Это не двузначное число, или оно не оканчивается на 3");
    }

    protected static void BankPercent()
    {
        Console.WriteLine("Вклад < 100 — 5% \n Вклад > 100 но < 200 — 7% \n Вклад > 200 — 10%");
        var sum = SharedFunctions.EnterInt("Введите сумму вклада:");

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
            Console.WriteLine("1: 4x^2-4x+1=0 \n 2: x^2+2x-48=0 \n 3: x^2+2x+5=0");
            var pointer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            var discr = 0;
            switch (pointer)
            {
                case '1':
                    Console.WriteLine($"D = 4^2-4*4*1 = 16-16 = {discr}");
                    Console.WriteLine("x1,2 = (4+√D)/2*4 = 4/8 = 0,5");
                    return;
                case '2':
                    Console.WriteLine("D = 2^2-4*1*(-48) = 4 + 192 = 196");
                    discr = 2 * 2 + -4 * -48;
                    Console.WriteLine($"x1 = (-2+√D)/2 = -2 + {Math.Sqrt(discr)}/2 = {(-2 + Math.Sqrt(discr)) / 2}");
                    Console.WriteLine($"x2 = (-2+√D)/2 = -2 - {Math.Sqrt(discr)}/2 = {(-2 - Math.Sqrt(discr)) / 2}");
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
        var day = SharedFunctions.EnterInt("Введите число 1-7:");
        while (day is >= 7 or < 0)
        {
            Console.WriteLine("Такого дня недели не существует");
            day = SharedFunctions.EnterInt("Введите число 1-7:");
        }

        Console.WriteLine(DateOnly.FromDayNumber(day - 1).DayOfWeek);
    }

    protected static void CargoRaces()
    {
        int v1, v2, t1, t2;

        Console.WriteLine("В одну сторону выезжают 2 грузовика.");
        v1 = SharedFunctions.EnterInt("Первый выехал со скоростью:");
        Console.Write("Через ");
        t1 = SharedFunctions.EnterInt("Через ");
        Console.Write("Выехал второй грузовик со скоростью ");
        v2 = SharedFunctions.EnterInt("Выехал второй грузовик со скоростью: ");
        Console.Write("И через ");
        t2 = SharedFunctions.EnterInt("И через ");
        Console.WriteLine(v1 * t1 <= v2 * t2
            ? "Второй грузовик догонит первый"
            : "Второй грузовик не догонит первый");
    }

    protected static void SystemOfFunctions()
    {
        var x = SharedFunctions.EnterInt("Введите x:");

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
        var sum = SharedFunctions.EnterInt("Введите сумму покупки:");

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

    protected static double RateDiscount()
    {
        Console.WriteLine("Выберите рейтинг покупателя, введя число от 0 до 5.");
        var rate = SharedFunctions.EnterInt("Введите рейтинг покупателя:");
        while (rate is > 5 or < 0)
        {
            Console.WriteLine("Рейтинг покупателя должен быть от 0 до 5.");
            rate = SharedFunctions.EnterInt("Введите рейтинг покупателя:");
        }

        var result = Discount();
        var ratedisc = rate switch
        {
            0 => 0,
            1 => 200,
            2 => 400,
            3 => 600,
            4 => 700,
            5 => 800,
            _ => throw new ArgumentOutOfRangeException()
        };
        Console.WriteLine($"Скидка за рейтинг покупателя - {ratedisc}");
        return Math.Round(result - ratedisc);
    }
    
    protected static void RandMath()
    {
        var first = Random.Shared.Next(1, 9);
        var second = Random.Shared.Next(1, 9);
        Console.WriteLine($"{first}*{second} = ");
        var result = SharedFunctions.EnterInt("Ответ:");

        Console.WriteLine(result == first * second ? "Верно." : "Неверно.");
    }
}