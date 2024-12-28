using CSLab.Lab4.FootballService.Entities;
using CSLab.Shared;

namespace CSLab.Lab4.FootballService;

// ReSharper disable once InconsistentNaming
internal abstract class FootballQuests
{
    protected static void TeamIndex(IEnumerable<Player> team)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        foreach (var player in team)
            Console.WriteLine($"{player.Name}: Возраст - {player.Age}, Амплуа - {player.Amplua}");
        Console.WriteLine("--------------------------------------------------------------------");
    }

    protected static Player EnterPlayer()
    {
        Console.WriteLine("Введите имя игрока:");
        var name = Console.ReadLine() ?? string.Empty;
        var age = SharedFunctions.EnterInt("Введите возраст игрока:");
        Skill? amplua = null;
        while (amplua == null)
        {
            var ampluaNum =
                SharedFunctions.EnterInt("Введите амплуа игрока \n 1 => Вратарь,\n 2 => Защитник,\n 3 => Форвард");
            amplua = ampluaNum switch
            {
                1 => Skill.Вратарь,
                2 => Skill.Защитник,
                3 => Skill.Форвард,
                _ => null
            };
        }

        return new Player(name, (Skill)amplua, age);
    }

    protected static void AmpluaFilter(IEnumerable<Player> team)
    {
        Skill? amplua = null;
        while (amplua == null)
        {
            var ampluaNum = SharedFunctions.EnterDouble("Введите амплуа для фильтрации:");
            Console.WriteLine(
                "1 => Вратарь,\n 2 => Защитник,\n 3 => Форвард");
            amplua = ampluaNum switch
            {
                1 => Skill.Вратарь,
                2 => Skill.Защитник,
                3 => Skill.Форвард,
                _ => null
            };
        }

        TeamIndex(team.Where(player => player.Amplua == amplua));
    }
}