using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string forwardWord = "Коллаборационизм";
            for (int i = forwardWord.Length; i > 0; i--)
            {
                Console.Write(forwardWord[i - 1]);
            }
            Console.WriteLine();
        }
    }
}
