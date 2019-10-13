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
            float x, y;

            Console.WriteLine("Введите первое число:");
            x = Validate(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            y = Validate(Console.ReadLine());

            float sum = Calculate(x,y);
            Console.WriteLine("Результат: " + sum);
            Console.ReadKey();
        }

        static float Calculate(float x, float y)
        {
            return x + y;
        }

        static float Validate(string input)
        {
            float y;
            while (!float.TryParse(input, out y))
            {
                Console.WriteLine("Введите валидное число!");
                input = Console.ReadLine();
            }
            return y;
        }
    }
}
