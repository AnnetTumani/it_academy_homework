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
            Object csharpObject = new Object();
            object clrObject = new object();

            Int32 csharpInteger = 1245;
            int clrInteger = 4123;

            String csharpString = "Is this c# type?";
            string clrString = "Is this CLR type?";

            Console.WriteLine(csharpObject.GetType());
            Console.WriteLine(clrObject.GetType());
            Console.WriteLine(csharpInteger.GetType());
            Console.WriteLine(clrInteger.GetType());
            Console.WriteLine(csharpString.GetType());
            Console.WriteLine(clrString.GetType());
            Console.ReadKey();
        }
    }
}
