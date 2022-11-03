internal class Program
{
    static DateTime date = DateTime.Now;
    static int menu = 1;
    static int position = 3, maxposition, minposition;
    static ConsoleKey click;
    static void Main()
    {
        int z = xClass.z;
        string x = xClass.x;
        xClass.Q(menu, position, z, x, maxposition, minposition, click, date);
    }
    public static void Menu(int z, string x)
    {
        Console.WriteLine("Кондитерская сеть 'Zefirka'\nУ нас вы сами можете собрать торт!\n-----------------------------------\n  Форма торта\n  Размер торта\n  Вкус торта\n  Количество коржей\n  Глазурь\n  Декор\n  Конец заказа");
        Console.WriteLine("Цена: " + z);
        Console.WriteLine("Ваш торт: " + x);
    }
    public static int CursorPosition(int position, int maxposition, int minposition, ConsoleKey click)
    {
        switch (click)
        {
            case ConsoleKey.UpArrow:
                Console.Clear();
                position--;
                if (position < minposition)
                {
                    position = minposition;
                }
                break;
            case ConsoleKey.DownArrow:
                Console.Clear();
                position++;
                if (position > maxposition)
                {
                    position = maxposition;
                };
                break;
        }
        return position;
    }
    public static void WriteCursor(int position)
    {
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");
    }
}