namespace CSLab.Lab2;

public abstract class Lab2 : Lab2Quests
{
    public static void Menu()
    {
        Console.WriteLine("Лабораторная 1:");
        Console.WriteLine(
            "Введите цифру от 0 до 9, для выбора задания. (d - для выполнение дополнительного общего задания)");
        Console.WriteLine("Введите \"Q\" для выхода в главное меню");
        var pointer = Console.ReadKey().KeyChar;
        while (true)
        {
            Console.WriteLine();
            switch (pointer)
            {
                case '0':
                    Console.WriteLine("Определить, является ли введенное число четным.");
                    Multiplicity(2);
                    break;
                case '1':
                    Console.WriteLine("Определить, является ли заданное число двузначным числом, оканчивающимся на 3.");
                    break;
                case '2':
                    Console.WriteLine("Начисления процента по вкладу в банке.");
                    Console.WriteLine("Вклад < 100 — 5%\0Вклад > 100 но < 200 — 7 %\0Вклад > 200 — 10%\0");
                    break;
                case '3':
                    Console.WriteLine("Нахождение корней квадратного уравнения.");
                    break;
                case '4':
                    Console.WriteLine("День недели по числу.");
                    break;
                case '5':
                    Console.WriteLine("Решение задачи.");
                    break;
                case '6':
                    Console.WriteLine("Проверка на кратность 3.");
                    Multiplicity(3);
                    break;
                case '7':
                    Console.WriteLine("Вычисление значения функции.");
                    break;
                case '8':
                    Console.WriteLine("Начисление скидки.");
                    Console.WriteLine("Сумма < 18000 — 1%\0Сумма > 18000 но < 30000 — 5%\0Сумма > 30000 — 10%\0");
                    break;
                case '9':
                    Console.WriteLine("Скидка по рейтингу покупателя.");
                    break;
                case 'd':
                    Console.WriteLine("Проверка знания таблицы умножения.");
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