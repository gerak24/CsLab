using CSLab.Lab4.Football.Entities;

namespace CSLab.Lab4.Football;

public abstract class LabFootball : LabFootballQuests
{
    private static List<Player> _team =
    [
        new("Иванов", Skill.Вратарь, 18),
        new("Петров", Skill.Защитник, 20)
    ];

    public static void Menu()
    {
        Console.WriteLine("Футбольный менеджер:");
        Console.WriteLine("1 - Список игроков.");
        Console.WriteLine("2 - Добавить игрока.");
        Console.WriteLine("3 - Количество игроков выбранного амплуа.");
        Console.WriteLine("4 - Количество совершеннолетних игроков.");
        Console.WriteLine("Введите \"Q\" для выхода в меню лабораторной №4");

        var pointer = Console.ReadKey().KeyChar;
        while (true)
        {
            Console.WriteLine();
            switch (pointer)
            {
                case '1':
                    TeamIndex(_team);
                    break;
                case '2':
                    _team.Add(EnterPlayer());
                    break;
                case '3':
                    _team.Add(EnterPlayer());
                    break;
                case '4':
                    _team.Add(EnterPlayer());
                    break;
                case 'Q':
                case 'q':
                    return;
            }

            Console.WriteLine("Для продолжения выберите задание введя цифру 1 или 2.");
            Console.WriteLine("Введите \"Q\" для выхода в главное меню");
            pointer = Console.ReadKey().KeyChar;
        }
    }
}