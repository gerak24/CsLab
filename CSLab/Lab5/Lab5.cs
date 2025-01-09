    using CSLab.Lab5.Entities;

    namespace CSLab.Lab5;

    public abstract class Lab5 : BookShopQuests
    {
        private static List<Book> _products = [];

        public static void Menu()
        {
            Console.WriteLine("Лабораторная 5:");
            Console.WriteLine("\"Книжный магазин\".");
            Console.WriteLine("1 - Список книг.");
            Console.WriteLine("2 - Добавить книгу.");
            Console.WriteLine("3 - Фильтровать по стоимости.");
            Console.WriteLine("Введите \"Q\" для выхода в меню лабораторной №5");

            var pointer = Console.ReadKey().KeyChar;
            while (true)
            {
                Console.WriteLine();
                switch (pointer)
                {
                    case '1':
                        BookIndex(_products);
                        break;
                    case '2':
                        _products.Add(EnterBook(_products));
                        break;
                    case '3':
                        CostFilter(_products);
                        break;
                    case 'Q':
                    case 'q':
                        return;
                }

                Console.WriteLine(
                    "Чтобы продолжить выберите действие:\n 1 - Список книг. \n 2 - Добавить книгу. \n 3 - Фильтровать по стоимости.");
                Console.WriteLine("Введите \"Q\" для выхода в меню лабораторной №5");
                pointer = Console.ReadKey().KeyChar;
            }
        }
    }