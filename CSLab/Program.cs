using CSLab.Lab1;
using CSLab.Lab2;

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
              //  new Lab3Menu().Menu();
                break;
            case '4':
              //  new Lab4Menu().Menu();
                break;
            case '5':
               // new Lab5Menu().Menu();
                break;
            case 'Q':
                return;
        }
        Console.WriteLine("Для продолжения выберите лабораторную введя цифру 1-5.");
        Console.WriteLine("Введите \"Q\" для выхода ");
        pointer = Console.ReadKey().KeyChar;
    }
}