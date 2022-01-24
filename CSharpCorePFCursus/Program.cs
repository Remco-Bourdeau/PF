using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Asterix");
            Console.Write(" en Obelix");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Suske");
            Console.SetCursorPosition(25,6);
            Console.WriteLine("Wiske");
        }
    }
}
