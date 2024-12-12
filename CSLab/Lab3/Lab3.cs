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
            switch (pointer)
            {
                case '1':
                    Console.WriteLine("Вывод всех чётных чисел от 1 до 100, их количества и суммы.");
                    EvenCheck();
                    break;
                case '2':
                    Console.WriteLine("Вывод всех чисел, оканчивающихся на 5 в заданном промежутке");
                    foreach (var result in EndCharAnalyze('5'))
                        Console.Write($"{result} ");
                    Console.WriteLine();
                    break;
                case '3':
                    Console.WriteLine("Вывести максимальное число, кратное 5, в заданном ряду.");
                    Console.WriteLine($"Максимальное число, кратное 5 = {EndCharAnalyze('5').Max()}");
                    break;
                case '4':
                    Console.WriteLine("Определить, является ли число простым");
                    break;
                case '5':
                    Console.WriteLine("«Угадай число!»");
                    break;
                case '6':
                    Console.WriteLine("«Тренажер таблицы умножения»");
                    break;
                case '7':
                    Console.WriteLine("Вывод всех чисел, оканчивающихся на 6 в заданном промежутке, их сумма и количество");
                    var results = EndCharAnalyze('6');
                    foreach (var result in results)
                        Console.Write($"{result} ");
                    Console.WriteLine();
                    Console.WriteLine($"Сумма чисел = {results.Sum()}");
                    Console.WriteLine($"Количество чётных чисел = {results.Count}");
                    break;
                case '8':
                    Console.WriteLine("Сумма вклада с ежемесячным процентом.");
                    break;
                case '9':
                    Console.WriteLine("Таблица умножения");
                    break;
                case 'Q':
                    return;
            }

            Console.WriteLine("Для продолжения выберите задание введя цифру 1-9.");
            Console.WriteLine("Введите \"Q\" для выхода в главное меню");
            pointer = Console.ReadKey().KeyChar;
        }
    }
}