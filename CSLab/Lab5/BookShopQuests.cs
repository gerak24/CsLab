﻿using CSLab.Lab5.Entities;
using CSLab.Shared;

namespace CSLab.Lab5;

// ReSharper disable once InconsistentNaming
public class BookShopQuests
{
    protected static void BookIndex(List<Book> books)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        foreach (var book in books)
            Console.WriteLine(
                $"{book.Name}: Автор - {book.Author}, Стоимость - {book.Price}, Год выпуска - {book.Year}");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine($"Общая стоимость: {books.Select(x => x.Price).Sum()}");
    }

    protected static Book EnterBook(List<Book> books)
    {
        Console.WriteLine("Введите название книги:");
        var name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Введите имя автора книги:");
        var author = Console.ReadLine() ?? string.Empty;
        var year = SharedFunctions.EnterInt("Введите год издания:");
        var price = (decimal)SharedFunctions.EnterDouble("Введите стоимость книги:");
        var number = Random.Shared.Next(1, 100000);
        while (books.Any(b => b.InventoryNum == number))
            number = Random.Shared.Next(1, 100000);

        Console.WriteLine($"Инвентарный номер добавленной книги: {number}");
        return new Book(number, name, author, year, price);
    }

    protected static void CostFilter(IEnumerable<Book> books)
    {
        var maxCost = (decimal)SharedFunctions.EnterDouble("Введите максимальную стоимость искомых книг:");
        BookIndex(books.Where(b => b.Price <= maxCost).ToList());
    }
}