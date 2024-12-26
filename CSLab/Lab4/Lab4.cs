using CSLab.Lab4.Football;

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
                    ArrSortedAnalyze(EnterArray(5));
                    break;
                case '2':
                    Console.WriteLine("Сортировка массива");
                    ArraySort(CreateRandArray(10, 0, 100));
                    break;
                case '3':
                    Console.WriteLine("Поиск числа в массиве.");
                    FindNumber(CreateRandArray(10, 0, 100));
                    break;
                case '4':
                    Console.WriteLine(
                        "Из массива A[20] вывести массив B[], отсортированный по убыванию, где все числа <= 888 (диапазон 0 -> 1000).");
                    GetCustomArray(CreateRandArray(20, 0, 1000));
                    break;
                case '5':
                    Console.WriteLine("Коллекция из приветствия и трёх случайных чисел.");
                    EasyCollection();
                    break;
                case '6':
                    Console.WriteLine("Коллекция из произвольных элементов.");
                    HardCollection();
                    break;
                case '7':
                    Console.WriteLine("Программа для формирования футбольной команды.");
                    LabFootball.Menu();
                    break;
                case 'Q':
                case 'q':
                    return;
            }

            Console.WriteLine("Для продолжения выберите задание введя цифру 1-7.");
            Console.WriteLine("Введите \"Q\" для выхода в главное меню");
            pointer = Console.ReadKey().KeyChar;
        }
    }
}