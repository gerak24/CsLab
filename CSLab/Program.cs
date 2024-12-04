
CircleCalc();

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