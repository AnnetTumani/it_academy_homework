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
            char ch = 's';
            int integer = 1214524365;
            float single = 3.123F;
            string date = "1992-12-01";
            short shorty = 1;
            sbyte bytes = default;
            long longer = 12654646541564123;


            // boxing/unboxing
            object box = integer;
            var unbox = (int)box;


            // явное преобразование
            string str = box.ToString();
            DateTime datetime = DateTime.Parse(date);
            decimal dec = Convert.ToDecimal(single);

            // неявное преобразование
            longer = integer;
            integer = shorty;
            shorty = bytes;



        }
    }
}
