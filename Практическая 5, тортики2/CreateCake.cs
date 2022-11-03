internal class Cake
{
    public int cost;
    public string forma;
    public string razmer;
    public string vkus;
    public string KolichestvoKorjey;
    public string glazur;
    public string decor;
    public Cake(int xCost, string xForm, string xRazm, string xVkus, string xKolKor, string xGlaz, string xDec)
    {
        cost = xCost;
        forma = xForm;
        razmer = xRazm;
        vkus = xVkus;
        KolichestvoKorjey = xKolKor;
        glazur = xGlaz;
        decor = xDec;
    }
}
internal class xClass
{
    static string[] forma = new string[4] { "  Круг - 500", "  Квадрат - 500", "  Прямоугольник - 500", "  Сердечко - 700" };
    static string[] razmer = new string[3] { "  Маленький - 1000", "  Обычный - 1200", "  Большой - 2000" };
    static string[] vkus = new string[5] { "  Ванильный - 100", "  Шоколадный - 100", "  Карамельный - 150", "  Ягодный - 200", "  Кокосовый - 250" };
    static string[] KolichestvoKorjey = new string[4] { "  1 корж - 200", "  2 коржа - 400", "  3 коржа - 600", "  4 коржа - 800" };
    static string[] glazur = new string[5] { "  Шоколад - 100", "  Крем - 100", "  Бизе - 150", "  Драже - 150", "  Ягоды - 200" };
    static string[] decor = new string[3] { "  Шоколадная - 150", "  Ягодная - 150", "  кремовая - 150" };
    private static int cost;
    private static string text;
    public static int z = 0;
    public static string x = "";
    private static DateTime date;
    public static int Q(int menu, int position, int z, string x, int maxposition, int minposition, ConsoleKey key, DateTime date)
    {
        maxposition = 9;
        minposition = 3;
        bool check = true;
        do
        {
            switch (menu)
            {
                case 1:
                    Program.Menu(z, x);
                    break;
                case 2:
                    Console.Clear();
                    xMenu(menu, key, position, maxposition, minposition);
                    break;
                case 3:
                    Console.Clear();
                    xMenu(menu, key, position, maxposition, minposition);
                    break;
                case 4:
                    Console.Clear();
                    xMenu(menu, key, position, maxposition, minposition);
                    break;
                case 5:
                    Console.Clear();
                    xMenu(menu, key, position, maxposition, minposition);
                    break;
                case 6:
                    Console.Clear();
                    xMenu(menu, key, position, maxposition, minposition);
                    break;
                case 7:
                    Console.Clear();
                    xMenu(menu, key, position, maxposition, minposition);
                    break;
            }
            Program.WriteCursor(position);
            key = Console.ReadKey().Key;
            position = Program.CursorPosition(position, maxposition, minposition, key);
            if (key == ConsoleKey.Backspace)
            {
                Console.Clear();
            }
            switch (menu)
            {
                case 1:
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 3:
                                    position = 0;
                                    menu = 2;
                                    break;
                                case 4:
                                    position = 0;
                                    menu = 3;
                                    break;
                                case 5:
                                    position = 0;
                                    menu = 4;
                                    break;
                                case 6:
                                    position = 0;
                                    menu = 5;
                                    break;
                                case 7:
                                    position = 0;
                                    menu = 6;
                                    break;
                                case 8:
                                    position = 0;
                                    menu = 7;
                                    break;
                                case 9:
                                    date = DateTime.Now;
                                    Console.Clear();
                                    File.AppendAllText("C:\\Users\\comas\\OneDrive\\Рабочий стол\\тортики.txt", "Время заказа " + date + "\n Цена:" + z + " Состав заказа: \n" + x);
                                    z = 0;
                                    x = "";
                                    xClass.z = 0;
                                    xClass.x = "";
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            check = false;
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
        } while (check);
        return menu;
    }
    private static void xMenu(int menu, ConsoleKey key, int position, int maxposition, int minposition)
    {
        cost = 0;
        text = "";
        bool check = true;
        do
        {
            switch (menu)
            {
                case 2:
                    Console.WriteLine(forma[0]);
                    Console.WriteLine(forma[1]);
                    Console.WriteLine(forma[2]);
                    Console.WriteLine(forma[3]);
                    Program.WriteCursor(position);
                    key = Console.ReadKey().Key;
                    position = Program.CursorPosition(position, maxposition, minposition, key);
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 0:
                                    text = forma[0];
                                    cost = 500;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 1:
                                    text = forma[1];
                                    cost = 500;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 2:
                                    text = forma[2];
                                    cost = 500;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 3:
                                    text = forma[3];
                                    cost = 700;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            position = 3;
                            Console.Clear();
                            menu = 1;
                            Q(menu, position, z, x, maxposition, minposition, key, date);
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine(razmer[0]);
                    Console.WriteLine(razmer[1]);
                    Console.WriteLine(razmer[2]);
                    Program.WriteCursor(position);
                    key = Console.ReadKey().Key;
                    position = Program.CursorPosition(position, maxposition, minposition, key);
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 0:
                                    text = razmer[0];
                                    cost = 1000;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 1:
                                    text = razmer[1];
                                    cost = 1200;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 2:
                                    text = razmer[2];
                                    cost = 2000;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            position = 4;
                            Console.Clear();
                            menu = 1;
                            Q(menu, position, z, x, maxposition, minposition, key, date);
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine(vkus[0]);
                    Console.WriteLine(vkus[1]);
                    Console.WriteLine(vkus[2]);
                    Console.WriteLine(vkus[3]);
                    Console.WriteLine(vkus[4]);
                    Program.WriteCursor(position);
                    key = Console.ReadKey().Key;
                    position = Program.CursorPosition(position, maxposition, minposition, key);
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 0:
                                    text = vkus[0];
                                    cost = 100;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 1:
                                    text = vkus[1];
                                    cost = 100;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 2:
                                    text = vkus[2];
                                    cost = 150;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 3:
                                    text = vkus[3];
                                    cost = 200;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 4:
                                    text = vkus[4];
                                    cost = 250;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            position = 5;
                            Console.Clear();
                            menu = 1;
                            Q(menu, position, z, x, maxposition, minposition, key, date);
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine(KolichestvoKorjey[0]);
                    Console.WriteLine(KolichestvoKorjey[1]);
                    Console.WriteLine(KolichestvoKorjey[2]);
                    Console.WriteLine(KolichestvoKorjey[3]);
                    Program.WriteCursor(position);
                    key = Console.ReadKey().Key;
                    position = Program.CursorPosition(position, maxposition, minposition, key);
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 0:
                                    text = KolichestvoKorjey[0];
                                    cost = 200;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 1:
                                    text = KolichestvoKorjey[1];
                                    cost = 400;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 2:
                                    text = KolichestvoKorjey[2];
                                    cost = 600;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 3:
                                    text = KolichestvoKorjey[3];
                                    cost = 800;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            position = 6;
                            Console.Clear();
                            menu = 1;
                            Q(menu, position, z, x, maxposition, minposition, key, date);
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine(glazur[0]);
                    Console.WriteLine(glazur[1]);
                    Console.WriteLine(glazur[2]);
                    Console.WriteLine(glazur[3]);
                    Console.WriteLine(glazur[4]);
                    Program.WriteCursor(position);
                    key = Console.ReadKey().Key;
                    position = Program.CursorPosition(position, maxposition, minposition, key);
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 0:
                                    text = glazur[0];
                                    cost = 100;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 1:
                                    text = glazur[1];
                                    cost = 100;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 2:
                                    text = glazur[2];
                                    cost = 150;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 3:
                                    text = glazur[3];
                                    cost = 150;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 4:
                                    text = glazur[4];
                                    cost = 200;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            position = 7;
                            Console.Clear();
                            menu = 1;
                            Q(menu, position, z, x, maxposition, minposition, key, date);
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine(decor[0]);
                    Console.WriteLine(decor[1]);
                    Console.WriteLine(decor[2]);
                    Program.WriteCursor(position);
                    key = Console.ReadKey().Key;
                    position = Program.CursorPosition(position, maxposition, minposition, key);
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            switch (position)
                            {
                                case 0:
                                    text = decor[0];
                                    cost = 150;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 1:
                                    text = decor[1];
                                    cost = 150;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                                case 2:
                                    text = decor[2];
                                    cost = 150;
                                    position = 8;
                                    Returned(menu, position, maxposition, minposition, key, date);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            position = 8;
                            Console.Clear();
                            menu = 1;
                            Q(menu, position, z, x, maxposition, minposition, key, date);
                            break;
                    }
                    break;
            }
        } while (check);
    }
    private static int Cost()
    {
        z = z + cost;
        return z;
    }
    private static string Text()
    {
        x = x + text;
        return x;
    }
    private static void Returned(int menu, int position, int maxposition, int minposition, ConsoleKey key, DateTime date)
    {
        Cost();
        Text();
        position = 3;
        Console.Clear();
        menu = 1;
        Q(menu, position, z, x, maxposition, minposition, key, date);
    }
}