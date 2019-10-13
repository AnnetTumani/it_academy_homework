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
            int[] mass = new int[8];

            Console.WriteLine("Введите 7 елементов массива");

            for (int i = 0; i < mass.Length-1; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введенный массив:");
            foreach (int element in mass)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("Введите ещё одно значение эл-та массива");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите его позицию в массиве");
            int poss = int.Parse(Console.ReadLine());

            for (int i = mass.Length-1; i != poss-1; i--)
            {
                mass[i] = mass[i-1];
            }
            mass[poss-1] = x;

            Console.WriteLine("Полученный массив: ");
            foreach (int element in mass)
            {
                Console.Write(element + " ");
            }


            Console.ReadKey();
        }
    }
}
