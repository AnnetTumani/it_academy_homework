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
            int[] random = new int[5], input = new int[5], sum = new int[5];
            var randomizer = new Random();

            Console.WriteLine("Введите 5 элементов массива");
            for (int i = 0; i < input.Length; i++)
            {
                random[i] = randomizer.Next(1, 20); //метод Next - генерирует случ. число от 1 до 20
                input[i] = int.Parse(Console.ReadLine());
                sum[i] = random[i] + input[i];
            }

            string first = default, second = default, third = default;
            foreach (var item in random)
            {
                first += item + " ";
            }
            Console.WriteLine("Полученные элементы рандомного массива: " + first);

            foreach (var item in input)
            {
                second += item + " ";
            }
            Console.WriteLine("Полученные элементы введенного массива: " + second);

            foreach (var item in sum)
            {
                third += item + " ";
            }
            Console.WriteLine("Полученные элементы суммированного массива: " + third);

            Console.ReadKey();
        }
    }
}
