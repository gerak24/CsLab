namespace CSLab.Lab4;

public class Lab4Quests
{
    public static int[] CreateRandArray(int length, int from, int to)
    {
        var result = new int[length];
        for (var i = 0; i < length; i++)
        {
            var random = new Random().Next(from, to);
            result[i] = random;
        }

        return result;
    }

    public static void ArrAnalyze(int[] array)
    {
        int multyply = 1,
            maxcounter = 0,
            mincounter = 0,
            evencount = 0,
            nevencount = 0,
            zerocount = 0,
            fivemcount = 0,
            customcount = 0;
        for (var i = 0; i < array.Length; i++)
        {
            multyply *= array[i];
            if (array[i] >= array.Max())
                maxcounter = i;
            else if (array[i] <= array.Min())
                mincounter = i;
            if (array[i] % 2 == 0 && array[i] != 0)
                evencount++;
            else if (array[i] == 0)
                zerocount++;
            else
                nevencount++;
            if (array[i] % 5 == 0)
                fivemcount++;
            if (array[i] % 3 == 0 && array[i].ToString().Last() == '9')
                customcount++;
        }

        Console.WriteLine($"Наибольший элемент = {array.Max()}, под индексом: {maxcounter}");
        Console.WriteLine($"Наименьший элемент = {array.Min()}, под индексом: {mincounter}");
        Console.WriteLine(
            $"Количество элементов массива: {array.Length}, их сумма: {array.Sum()}, их произведение {multyply}");
        Console.WriteLine(
            $"Количество чётных элементов массива: {evencount}. Количество нечётных элементов массива: {nevencount}. Количество нулевых элементов массива: {zerocount}");
        Console.WriteLine($"Количество элементов массива кратных 5: {fivemcount}");
        Console.WriteLine($"Количество элементов массива кратных 3 и заканчивающихся на 9: {customcount}");
    }
}