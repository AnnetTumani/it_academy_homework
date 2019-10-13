using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");

            var input = Console.ReadLine();
            input = input.Replace("O", "A");
            input = input.Replace("О", "А");
            var rows = input.Split(';');

            Console.WriteLine("Вывод строки массивом, как будто столбиком :)");

            foreach (var row in rows)
            {
                Console.WriteLine(row);
            }
            Console.ReadKey();
        }
    }
}
