namespace CSLab.Lab1;

public class Lab1Menu : Lab1Quests
{
    public void Menu()
    {
        Console.WriteLine("Лабораторная 1:");
        Console.WriteLine("Введите цифру от 1 до 7, для выбора задания.");
        Console.WriteLine("Введите \"Q\" для выхода в главное меню");
        var pointer = Console.ReadKey().KeyChar;
        while (true)
        {
            Console.WriteLine();
            switch (pointer)
            {
                case '1':
                    Console.WriteLine("Вычислить длину окружности, площадь круга и объем сферы по заданному радиусу.");
                    CircleCalc();
                    break;
                case '2':
                    Console.WriteLine("Поменять местами значения двух переменных.");
                    SwapVars();
                    break;
                case '3':
                    Console.WriteLine("Вычислить сумму и произведение чисел произвольного трехзначного числа.");
                    CalculateNumber();
                    break;
                case '4':
                    Console.WriteLine("Вычислить значение функции y=f(x).");
                    EasyFunc();
                    break;
                case '5':
                    Console.WriteLine("Вычислить значение выражения.");
                    HardFunc();
                    break;
                case '6':
                    Console.WriteLine("Найти сумму и произведение цифр четырехзначного числа.");
                    CalculateNumber(true);
                    break;
                case '7':
                    Console.WriteLine("Вывести  наибольшее из целых чисел A и B.");
                    MinMax();
                    break;
                case 'Q':
                    return;
            }

            Console.WriteLine("Для продолжения выберите задание введя цифру 1-7.");
            Console.WriteLine("Введите \"Q\" для выхода в главное меню");
            pointer = Console.ReadKey().KeyChar;
        }
    }
}