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
            float x, y, answer;

            Console.WriteLine("Введите первое число:");
            x = Validate(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            y = Validate(Console.ReadLine());

            Console.WriteLine("Введите сумму:");
            answer = Validate(Console.ReadLine());

            float sum = Calculate(x, y);
            string result = sum == answer ? "Правильно." : "Неправильно,";
            if (result == "Неправильно,")
            {
                result = answer < sum ? result + " должно быть больше." : result + " должно быть меньше.";
            }
            Console.WriteLine(result);
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