using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для сохранения в файл");
            File.WriteAllText("text.txt", Console.ReadLine());
        }
    }
}
