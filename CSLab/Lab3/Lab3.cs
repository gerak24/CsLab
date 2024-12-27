using CSLab.Shared;

namespace CSLab.Lab3;

public abstract class Lab3 : Lab3Quests
{
    public static void Menu()
    {
        Console.WriteLine("Лабораторная 3:");
        Console.WriteLine("Введите цифру от 1 до 9, для выбора задания.");
        Console.WriteLine("Введите \"Q\" для выхода в главное меню");
        var pointer = Console.ReadKey().KeyChar;
        while (true)
        {
            Console.WriteLine();
            List<int> results;
            switch (pointer)
            {
                case '0':
                    Console.WriteLine("Вывод всех чётных чисел от 1 до 100, их количества и суммы.");
                    results = MultiplicityAnalyze(1, 100, 2);
                    foreach (var result in results)
                        Console.Write($"{result} ");
                    Console.WriteLine($"Сумма чётных чисел = {results.Sum()}");
                    Console.WriteLine($"Количество чётных чисел = {results.Count}");
                    break;
                case '1':
                    Console.WriteLine("Вывод всех чисел, оканчивающихся на 5 в заданном промежутке");
                    foreach (var result in EndCharAnalyze('5'))
                        Console.Write($"{result} ");
                    Console.WriteLine();
                    break;
                case '2':
                    Console.WriteLine("Вывести максимальное число, кратное 5, в заданном ряду.");
                    var max = MultiplicityAnalyze(SharedFunctions.EnterInt("Введите начало промежутка"),
                        SharedFunctions.EnterInt("Введите конец промежутка"), 5).Max();
                    Console.WriteLine($"Максимальное число, кратное 5 = {max}");
                    break;
                case '3':
                    Console.WriteLine("Определить, является ли число простым");
                    Console.WriteLine(EasyNum(SharedFunctions.EnterInt("Введите число: "))
                        ? "Число является простым"
                        : "Число не является простым");
                    break;
                case '4':
                    Console.WriteLine("«Угадай число!»");
                    Guessing();
                    break;
                case '5':
                    Console.WriteLine("«Тренажер таблицы умножения»");
                    MultiplyTrainer();
                    break;
                case '6':
                    Console.WriteLine("«Все простые числа в диапазоне»");
                    EasyNums();
                    break;
                case '7':
                    Console.WriteLine(
                        "Вывод всех чисел, оканчивающихся на 6 в заданном промежутке, их сумма и количество");
                    results = EndCharAnalyze('6');
                    SharedFunctions.PrintArray(results);
                    Console.WriteLine($"Сумма = {results.Sum()}");
                    Console.WriteLine($"Количество = {results.Count}");
                    break;
                case '8':
                    Console.WriteLine("Сумма вклада с ежемесячным процентом.");
                    PercentCalc();
                    break;
                case '9':
                    Console.WriteLine("Таблица умножения");
                    MultiplyTable();
                    break;
                case 'Q':
                case 'q':
                    return;
            }

            Console.WriteLine("Для продолжения выберите задание введя цифру 1-9.");
            Console.WriteLine("Введите \"Q\" для выхода в главное меню");
            pointer = Console.ReadKey().KeyChar;
        }
    }
}