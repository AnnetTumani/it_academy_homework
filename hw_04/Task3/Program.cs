using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double primaryDeposit = 1000, percent = 0.02, deposit;

            Console.WriteLine("Сколько месяцев прошло?");
            var count = Validate(Console.ReadLine());

            deposit = primaryDeposit;
            for (int i = 0; i < count; i++)
            {
                deposit += deposit*percent;
            }

            Console.WriteLine("Прирост суммы вклада составил: " + (deposit-primaryDeposit));
            Console.WriteLine("Cумма вклада равна: " + deposit);
            Console.ReadKey();

        }
        static int Validate(string input)
        {
            int y;
            while (!int.TryParse(input, out y))
            {
                Console.WriteLine("Введите валидное число!");
                input = Console.ReadLine();
            }
            return y;
        }

    }
}
