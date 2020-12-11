using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string nameEntered = Console.ReadLine();
            Console.WriteLine($"Привет, {nameEntered}, сегодня {DateTime.Now}");
        }
    }
}
