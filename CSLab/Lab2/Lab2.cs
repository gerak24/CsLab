namespace CSLab.Lab2;

public  abstract class Lab2 : Lab2Quests
{
    public static void Menu()
    {
        Console.WriteLine("Лабораторная 1:");
        Console.WriteLine("Введите цифру от 0 до 9, для выбора задания. (d - для выполнение дополнительного общего задания)");
        Console.WriteLine("Введите \"Q\" для выхода в главное меню");
        var pointer = Console.ReadKey().KeyChar;
        while (true)
        {
            Console.WriteLine();
            switch (pointer)
            {
                case '0':
                    Console.WriteLine("Определить, является ли введенное число четным.");
                    break;
                case '1':
                    Console.WriteLine("Определить, является ли заданное число двузначным числом, оканчивающимся на 3.");
                    break;
                case '2':
                    Console.WriteLine("Начисления процента по вкладу в банке.");
                    Console.WriteLine("Вклад < 100 — 5%\0Вклад > 100 но < 200 — 7 %\0Вклад > 200 — 10%\0");
                    break;
                case '3':
                    Console.WriteLine("Вычислить сумму и произведение чисел произвольного трехзначного числа.");
                    break;
                case '4':
                    Console.WriteLine("Вычислить значение функции y=f(x).");
                    break;
                case '5':
                    Console.WriteLine("Вычислить значение выражения.");
                    break;
                case '6':
                    Console.WriteLine("Найти сумму и произведение цифр четырехзначного числа.");
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
                case 'd':
                    Console.WriteLine("Вычислить длину окружности, площадь круга и объем сферы по заданному радиусу.");
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