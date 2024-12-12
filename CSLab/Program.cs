using CSLab.Lab1;
using CSLab.Lab2;
using CSLab.Lab3;
using CSLab.Lab4;
using CSLab.Lab5;

Main();
return;

void Main()
{
    Console.WriteLine("Здравствуйте вы в меню лабораторных, выберите лабораторную введя цифру 1-5.");
    Console.WriteLine("Введите \"Q\" для выхода");
    var pointer = Console.ReadKey().KeyChar;
    while (true)
    {
        Console.WriteLine();
        switch (pointer)
        {
            case '1':
                Lab1.Menu();
                break;
            case '2':
                Lab2.Menu();
                break;
            case '3':
                Lab3.Menu();
                break;
            case '4':
                Lab4.Menu();
                break;
            case '5':
                Lab5.Menu();
                break;
            case 'Q':
                return;
        }

        Console.WriteLine("Для продолжения выберите лабораторную введя цифру 1-5.");
        Console.WriteLine("Введите \"Q\" для выхода ");
        pointer = Console.ReadKey().KeyChar;
    }
}