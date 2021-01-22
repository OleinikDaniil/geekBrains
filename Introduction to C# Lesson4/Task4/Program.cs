using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления числа Фибоначи");
            int FibonachiInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FibonachiNumber(FibonachiInput));
        }

        static int FibonachiNumber(int numberInput)
        {
            if (numberInput == 0 || numberInput == 1)
            {
                return numberInput;
            }
            else
            {
                return FibonachiNumber(numberInput - 1) + FibonachiNumber(numberInput - 2);
            }
        }
    }
}
