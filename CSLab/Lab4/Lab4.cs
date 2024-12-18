namespace CSLab.Lab4;

public abstract class Lab4 : Lab4Quests
{
    public static void Menu()
    {
        Console.WriteLine("Лабораторная 4:");
        Console.WriteLine("Введите цифру от 1 до 7, для выбора задания.");
        Console.WriteLine("Введите \"Q\" для выхода в главное меню");

        var pointer = Console.ReadKey().KeyChar;
        while (true)
        {
            Console.WriteLine();
            switch (pointer)
            {
                case '0':
                    Console.WriteLine("Массив 10 случайных натуральных чисел в диапазоне от 0 до 100");
                    var arr = CreateRandArray(10, 0, 100);
                    Console.Write("Массив: ");
                    foreach (var num in arr)
                        Console.Write($"{num} ");
                    Console.WriteLine();
                    ArrAnalyze(arr);
                    break;
                case '1':
                    Console.WriteLine("Определить, является ли расположение чисел в массиве упорядоченным ");
                    break;
                case '2':
                    Console.WriteLine("Вычислить сумму и произведение чисел произвольного трехзначного числа.");
                    break;
                case '3':
                    Console.WriteLine("Вычислить значение функции y=f(x).");
                    break;
                case '4':
                    Console.WriteLine("Вычислить значение выражения.");
                    break;
                case '5':
                    Console.WriteLine("Найти сумму и произведение цифр четырехзначного числа.");
                    break;
                case '6':
                    Console.WriteLine("Вывести  наибольшее из целых чисел A и B.");
                    break;
                case '7':
                    Console.WriteLine("Вывести  наибольшее из целых чисел A и B.");
                    break;
                case '8':
                    Console.WriteLine("Вывести  наибольшее из целых чисел A и B.");
                    break;
                case '9':
                    Console.WriteLine("Вывести  наибольшее из целых чисел A и B.");
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