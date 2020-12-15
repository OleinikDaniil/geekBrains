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
            Console.WriteLine("Введите целое число");
            string numberInput = Console.ReadLine();
            double numberInputDoubleHalf = Convert.ToDouble(numberInput) / 2 + 0.1 ;
            int roundedUp = Convert.ToInt32(numberInputDoubleHalf);
            int roundedDown = (int)numberInputDoubleHalf;
            Console.WriteLine(roundedDown);
            if ((roundedUp - roundedDown) == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
