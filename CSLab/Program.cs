CircleCalc();
SwapVars();
CalculateNumber();
return;

void CircleCalc()
{
    Console.WriteLine("Введите радиус окружности:");
    double? rad = null;
    while (rad == null)
    {
        try
        {
            Console.WriteLine("Введите x:");
            rad = float.Parse(Console.ReadLine() ?? "0");
        }
        catch (Exception)
        {
            rad = null;
        }
    }

    Console.WriteLine($"Площадь крга = {Math.PI * Math.Pow((double)rad, 2)}");
    Console.WriteLine($"Площадь сферы = {4.0 / 3.0 * Math.PI * Math.Pow((double)rad, 3)}");
}

void SwapVars()
{
    Console.WriteLine("Введите значение первой переменной:");
    var first = Console.ReadLine() ?? "0";
    Console.WriteLine("Введите значение первой переменной:");
    var second = Console.ReadLine() ?? "0";

    Console.WriteLine($"Переменные:{first} - {second}");
    (first, second) = (second, first);
    Console.WriteLine($"Переменные:{first} - {second}");
}

void CalculateNumber()
{
    int? number = null;
    while (number == null)
    {
        try
        {
            Console.WriteLine("Введите трёхзначное число:");
            number = int.Parse(Console.ReadLine() ?? "0");
            if (number is < 100 and > -100)
                throw new Exception();
        }
        catch (Exception)
        {
            number = null;
        }
    }

    Console.WriteLine($"Сумма цифр числа: {number / 100 + number % 100 / 10 + number % 10}");
    Console.WriteLine($"Произведение цифр числа: {number / 100 * (number % 100 / 10) * (number % 10)}");
}