namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.CursorTop++;
                        Console.CursorLeft--;
                        Console.Write("*");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.CursorTop--;
                        Console.CursorLeft--;
                        Console.Write("*");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write("*");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.CursorLeft = Console.CursorLeft - 2;
                        Console.Write("*");
                        break;
                }
            }
        }
    }
}
