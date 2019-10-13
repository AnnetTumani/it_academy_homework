using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для завершения программы нажмите ESC");

            while (true)
            {
                var key = Console.ReadKey();
                Console.Clear();
                if (key.KeyChar == '\u001b') break;
                switch (key.KeyChar)
                {
                    case 'w':
                        Console.WriteLine("Для завершения программы нажмите ESC");
                        Console.WriteLine("ВВЕРХ!");
                        break;
                    case 'a':
                        Console.WriteLine("Для завершения программы нажмите ESC");
                        Console.WriteLine("ВЛЕВО!");
                        break;
                    case 's':
                        Console.WriteLine("Для завершения программы нажмите ESC");
                        Console.WriteLine("ВНИЗ!");
                        break;
                    case 'd':
                        Console.WriteLine("Для завершения программы нажмите ESC");
                        Console.WriteLine("ВПРАВО!");
                        break;
                    default:
                        Console.WriteLine("Для завершения программы нажмите ESC");
                        Console.WriteLine("КУДА ИДТИ?!");
                        break;
                }
            }
        }
    }
}
