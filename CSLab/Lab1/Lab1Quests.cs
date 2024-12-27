using CSLab.Shared;

namespace CSLab.Lab1;

public class Lab1Quests
{
    protected static void CircleCalc()
    {
        var rad = SharedFunctions.EnterDouble("Введите радиус окружности:");
        Console.WriteLine($"Площадь крга = {Math.PI * Math.Pow(rad, 2)}");
        Console.WriteLine($"Площадь сферы = {4.0 / 3.0 * Math.PI * Math.Pow(rad, 3)}");
    }

    protected static void SwapVars()
    {
        Console.WriteLine("Введите значение первой переменной:");
        var first = Console.ReadLine() ?? "0";
        Console.WriteLine("Введите значение второй переменной:");
        var second = Console.ReadLine() ?? "0";

        Console.WriteLine($"Переменные:{first} - {second}");
        (first, second) = (second, first);
        Console.WriteLine($"Переменные:{first} - {second}");
    }

    protected static void CalculateNumber(bool hardMode)
    {
        var number =
            SharedFunctions.EnterInt(hardMode ? "Введите четырёхзначное число:" : "Введите трёхзначное число:");
        while (hardMode ? number is > 1000 or < -1000 : number is > 100 or < -100)
        {
            number = SharedFunctions.EnterInt(hardMode
                ? "Введите четырёхзначное число:"
                : "Введите трёхзначное число:");
        }

        Console.WriteLine(
            $"Сумма цифр числа: {(
                hardMode ? number / 1000 + number % 1000 / 100 + number % 100 / 10 + number % 10
                    : number / 100 + number % 100 / 10 + number % 10)}");
        Console.WriteLine(
            $"Произведение цифр числа: {(
                hardMode ? number / 1000 * (number % 1000 / 100) * (number % 100 / 10) * (number % 10)
                    : number / 100 * (number % 100 / 10) * (number % 10))}");
    }

    protected static void EasyFunc()
    {
        var x = SharedFunctions.EnterDouble("Введите x:");

        Console.WriteLine($"y = sin(pi+3^√sin^2 * {x})");

        var result = Math.Sin(Math.PI + Math.Cbrt(Math.Pow(Math.Sin(x), 2)));
        Console.WriteLine($"y = {Math.Round(result, 3)}");
        Console.WriteLine($"Целая часть: {Math.Truncate(result)} Дробная часть {result}");
    }

    protected static void HardFunc()
    {
        double x = double.Pow(0.4, 10) + 4,
            y = -0.875,
            z = double.Pow(-0.475, 10) - 3;
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"z = {z}");
        Console.WriteLine("w = |cosx-cosy|^(1+2sin^2y)*(1+z+z^2/2+z^3/3+z^4+4)");

        var result = double.Pow(double.Abs(double.Cos(x) - double.Cos(y)), 1 + 2 * double.Pow(double.Sin(y), 2)) *
                     (1 + z + double.Pow(z, 2) / 2 + double.Pow(z, 3) / 3 + double.Pow(z, 4) / 4);
        Console.WriteLine($"w = {result}");
    }

    protected static void MinMax()
    {
        var first = SharedFunctions.EnterInt("Введите  значение первого число:");
        var second = SharedFunctions.EnterInt("Введите значение второго числа:");

        Console.WriteLine($"Наибольшее из чисел: {int.Max(first, second)}");
    }
}