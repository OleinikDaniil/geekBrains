using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int FibonachiRecurse(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return FibonachiRecurse(number - 1) + FibonachiRecurse(number - 2);
            }
        }
        static int FibonachiCycle(int number)
        {
            int fiboResult = 0;
            int cycleTemp = 1;
            int fibonachiTemp;

            for (int i = 0; i < number; i++)
            {
                fibonachiTemp = fiboResult;
                fiboResult = cycleTemp;
                cycleTemp += fibonachiTemp;
            }

            return fiboResult;
        }
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            bool toParse = Int32.TryParse(userInput, out int parsedInput);
            Console.WriteLine(FibonachiRecurse(parsedInput));
            Console.WriteLine(FibonachiCycle(parsedInput));
        }
    }
}
