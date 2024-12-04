CircleCalc();
SwapVars();
CalculateNumber();
return;

void CircleCalc()
{
    Console.WriteLine("Введите радиус окружности:");

    var rad = float.Parse(Console.ReadLine() ?? "0");
    while (rad == 0)
    {
        Console.WriteLine("Введите радиус окружности:");
        rad = float.Parse(Console.ReadLine() ?? "0");
    }

    Console.WriteLine($"Площадь крга = {Math.PI * double.Pow(rad, 2)}");
    Console.WriteLine($"Площадь сферы = {4.0 / 3.0 * Math.PI * double.Pow(rad, 3)}");
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
    Console.WriteLine("Введите трёхзначное число:");
    var number = int.Parse(Console.ReadLine() ?? "0");
    while (number is < 100 and > -100)
    {
        Console.WriteLine("Введите трёхзначное число:");
        number = int.Parse(Console.ReadLine() ?? "0");
    }

    Console.WriteLine($"Сумма цифр числа: {number / 100 + number % 100 / 10 + number % 10}");
    Console.WriteLine($"Произведение цифр числа: {number / 100 * (number % 100 / 10) * (number % 10)}");
}