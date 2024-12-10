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
                    NumAnalyze();
                    break;
                case '2':
                    Console.WriteLine("Начисления процента по вкладу в банке.");
                    BankPercent();
                    break;
                case '3':
                    Console.WriteLine("Нахождение корней квадратного уравнения.");
                    QuadraticEquations();
                    break;
                case '4':
                    Console.WriteLine("День недели по числу.");
                    DayOfWeek();
                    break;
                case '5':
                    Console.WriteLine("Решение задачи.");
                    CargoRaces();
                    break;
                case '6':
                    Console.WriteLine("Проверка на кратность 3.");
                    Multiplicity(3);
                    break;
                case '7':
                    Console.WriteLine("Вычисление значения функции.");
                    SystemOfFunctions();
                    break;
                case '8':
                    Console.WriteLine("Начисление скидки.");
                    Console.WriteLine($"Итого к оплате: {Discount()}");
                    break;
                case '9':
                    Console.WriteLine("Скидка по рейтингу покупателя.");
                    Console.WriteLine("Введите рейтинг покупателя:");
                    Console.WriteLine($"Итого к оплате: {Discount(Console.ReadKey().KeyChar)}");
                    break;
                case 'd':
                    Console.WriteLine("Проверка знания таблицы умножения.");
                    RandMath();
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