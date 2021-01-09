using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число от 0 до 255");
                    string inputByte = Console.ReadLine();
                    byte [] convertedByte = {0};
                    convertedByte [0] = Convert.ToByte(inputByte);
                    File.WriteAllBytes("start.bin", convertedByte);
                    break;
                }
                catch
                {
                    continue;
                }
            }

        }
    }
}
