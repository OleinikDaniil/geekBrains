using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Blockscheme()
        {
            string n = Console.ReadLine();
            int number = Int32.Parse(n);
            int d = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    d++;
            }
            if (d == 0)
                Console.WriteLine("Простое");
            else
                Console.WriteLine("Не простое");
        }
        static void Main(string[] args)
        {
            Blockscheme();
        }
    }
}
