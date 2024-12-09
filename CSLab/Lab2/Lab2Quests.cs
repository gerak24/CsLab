using static System.Int32;

namespace CSLab.Lab2;

public abstract class Lab2Quests
{
    protected static void Multiplicity(int brief)
    {
        var success = false;
        while (!success)
        {
            Console.WriteLine("Введите число:");
            success = TryParse(Console.ReadLine(), out var digits);
            switch (digits % brief == 0)
            {
                case true : 
                        Console.WriteLine($"Число кратно {brief}");
                    break;
                case false : 
                    Console.WriteLine($"Число не кратно {brief}");
                    break;
            }
        }
    }
}