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
            for (int i = 90; i > 64; i--)
            {
                char c = Convert.ToChar(i);
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
