using CSLab.Lab4.FootballService.Entities;

namespace CSLab.Lab4.FootballService;

// ReSharper disable once InconsistentNaming
internal abstract class Football : FootballQuests
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
                    AmpluaFilter(_team);
                    break;
                case '4':
                    Console.WriteLine("Совершеннолетние игроки:");
                    Console.WriteLine(
                        $"Количество совершеннолетних игроков = {_team.Count(player => player.Age >= 18)}");
                    TeamIndex(_team.Where(x => x.Age >= 18));
                    break;
                case 'Q':
                case 'q':
                    return;
            }

            Console.WriteLine(
                "Чтобы продолжить выберите действие:\n 1 - Список игроков. \n 2 - Добавить игрока. \n 3 - Количество игроков выбранного амплуа. \n 4 - Количество совершеннолетних игроков.");
            Console.WriteLine("Введите \"Q\" для выхода в меню лабораторной №4");
            pointer = Console.ReadKey().KeyChar;
        }
    }
}