using CSLab.Lab4.Football.Entities;

namespace CSLab.Lab4.Football;

public class LabFootballQuests
{
    protected static int EnterNum(string text)
    {
        var success = false;
        var num = 0;
        while (!success)
        {
            Console.WriteLine(text);
            success = int.TryParse(Console.ReadLine(), out num);
        }

        return num;
    }

    protected static Player EnterPlayer()
    {
        Console.WriteLine("Введите имя игрока:");
        var playerName = Console.ReadLine() ?? string.Empty;
        var playerAge = EnterNum("Введите возраст игрока:");
        Console.WriteLine(
            "1 => Вратарь,\n 2 => Защитник,\n 3 => Форвард");
        Skill? playerAmplua = null;
        while (playerAmplua == null)
        {
            var playerAmpluaNum = EnterNum("Введите амплуа игрока");
            playerAmplua = playerAmpluaNum switch
            {
                1 => Skill.Вратарь,
                2 => Skill.Защитник,
                3 => Skill.Форвард,
                _ => null
            };
        }

        return new Player(playerName, (Skill)playerAmplua, playerAge);
    }

    protected static void TeamIndex(List<Player> team)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        foreach (var player in team)
            Console.WriteLine($"{player.Name}: Возраст - {player.Age}, Амплуа - {player.Amplua}");
        Console.WriteLine("--------------------------------------------------------------------");
    }
}