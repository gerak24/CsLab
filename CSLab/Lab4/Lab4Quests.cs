namespace CSLab.Lab4;

public class Lab4Quests
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

    protected static int[] EnterArray(int length)
    {
        var array = new int[length];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = EnterNum($"Введите элемент массива № {i + 1}");
        }

        return array;
    }

    protected static void PrintArray(IEnumerable<int> array)
    {
        Console.WriteLine("Массив:");
        foreach (var i in array)
            Console.Write($"{i} ");
        Console.WriteLine();
    }

    protected static int[] CreateRandArray(int length, int from, int to)
    {
        var result = new int[length];
        for (var i = 0; i < length; i++)
        {
            var random = new Random().Next(from, to);
            result[i] = random;
        }

        return result;
    }

    protected static void ArrAnalyze(int[] array)
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

    protected static void ArrSortedAnalyze(int[] array)
    {
        var byMax = true;
        var byMin = true;
        for (var i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
                byMin = false;
            else if (array[i] < array[i - 1])
                byMax = false;
        }

        if (byMax)
            Console.WriteLine("Массив упорядочен по возрастанию");
        if (byMin)
            Console.WriteLine("Массив упорядочен по убыванию");
        if (!byMin && !byMax)
            Console.WriteLine("Массив не упорядочен");
    }

    protected static void ArraySort(int[] array)
    {
        PrintArray(array);

        var pointer = '\0';
        while (pointer != 'y' && pointer != 'n')
        {
            Console.WriteLine("Сортировать по возрастанию? y - Да n - Нет");
            pointer = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        var byMax = pointer switch
        {
            'y' or 'Y' => true,
            'N' or 'n' => false,
            _ => throw new ArgumentOutOfRangeException()
        };

        Console.WriteLine(byMax ? "Массив по возрастанию:" : "Массив по убыванию:");
        PrintArray(byMax ? array.OrderDescending().Reverse() : array.OrderDescending());
    }

    protected static void FindNumber(int[] array)
    {
        PrintArray(array);
        var num = EnterNum("Введите искомое число");

        var index = Array.FindIndex(array, i => num == i);
        Console.WriteLine(index >= 0
            ? $"Искомое число находится под индексом {index + 1}"
            : "В массиве отсутствует искомое число");
    }

    protected static void GetCustomArray(int[] array)
    {
        PrintArray(array);
        var customArray = array.Where(x => x <= 888);
        PrintArray(customArray.OrderDescending());
    }

    protected static void EasyCollection()
    {
        var collection = new List<object>();
        Console.WriteLine("Введите приветствие: ");
        collection.Add(Console.ReadLine() ?? "");
        for (var i = 0; i < 3; i++)
            collection.Add(new Random().Next(0, 100));
        Console.WriteLine("Коллекция: ");
        foreach (var item in collection)
            Console.WriteLine(item);
    }

    protected static void HardCollection()
    {
        var collection = new List<object>();
        var itemCount = EnterNum("Введите количество элементов коллекции:");
        Console.WriteLine("Введите элементы: ");
        for (var i = 0; i < itemCount; i++)
            collection.Add(Console.ReadLine() ?? "");
        Console.WriteLine("Коллекция: ");
        var numCount = 0;
        foreach (var item in collection)
        {
            numCount = double.TryParse(item.ToString(), out _) ? numCount + 1 : numCount;
            Console.WriteLine(item);
        }

        Console.WriteLine($"Количество числовых элементов = {numCount}");
        Console.WriteLine($"Количество нечисловых элементов = {itemCount - numCount}");
    }
    
}