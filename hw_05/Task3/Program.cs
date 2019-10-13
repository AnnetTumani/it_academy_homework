using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            var elementsCount = int.Parse(Console.ReadLine());

            var array = RandomizeArray(elementsCount);

            var timer = Stopwatch.StartNew();
            Array.Reverse(array);
            timer.Stop();
            Console.WriteLine("Время выполнения System.Array.Reverse: " + timer.ElapsedMilliseconds + " ms");

            timer.Reset();
            timer.Start();
            ReverseArray(ref array);
            timer.Stop();
            Console.WriteLine("Время выполнения моего реверсирования: " + timer.ElapsedMilliseconds + " ms");

            Console.ReadKey();
        }

        static void ReverseArray(ref int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int z = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = z;
            }
        }

        static int[] RandomizeArray(int elementsCount)
        {
            int[] array = new int[elementsCount];
            var randomizer = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomizer.Next(1, 25);
            }
            return array;
        }
    }
}
