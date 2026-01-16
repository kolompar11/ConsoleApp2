using System.Drawing;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var szamok = Enumerable.Range(0, 100).Select(x=>x.ToString());
            File.WriteAllLines("szamok.txt",szamok);
            string[] beolvasottSorok = File.ReadAllLines("szamok.txt");
            int[] beolvasottSzamok = beolvasottSorok.Select(x => int.Parse(x)).ToArray();
            */



            Console.Write("B = Blue  W = White  G = Green  R = Red  Y = Yellow");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.CursorTop++;
                        Console.CursorLeft--;
                        Console.Write(" ");
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 1)
                        {
                            Console.CursorTop--;
                            Console.CursorLeft--;
                            Console.Write(" ");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write(" ");
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 1)
                        {
                            Console.CursorLeft = Console.CursorLeft - 2;
                            Console.Write(" ");
                        }
                        break;
                    case ConsoleKey.Delete:
                        Console.Clear();
                        Console.Write("B = Blue  W = White  G = Green  R = Red  Y = Yellow");
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(" ");
                        break;
                    case ConsoleKey.B:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("");
                        break;
                    case ConsoleKey.W:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("");
                        break;
                    case ConsoleKey.R:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("");
                        break;
                    case ConsoleKey.G:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("");
                        break;
                    case ConsoleKey.Q:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("");
                        break;
                    case ConsoleKey.Y:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write("");
                        break;

                }
            }
        }
    }
}
