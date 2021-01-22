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
            Console.WriteLine("Введите числа от 0 до 9 в строку, разделяя их пробелом, чтобы получить сумму");
            string stringSum = Console.ReadLine();
            Console.WriteLine(Sum(stringSum));

        }

        static int Sum(string numbers)
        {
            int numInt = 0;
            for (int i = 0, Summ = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == ' ')
                {
                    continue;
                }
                numInt = numInt + Int32.Parse(numbers[i].ToString());
            }
            return numInt;
        }
    }
}
