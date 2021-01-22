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
            Console.WriteLine(GetFullName("Василий", "Волков", "Петрович"));
            Console.WriteLine(GetFullName("Петр", "Козлов", "Васильевич"));
            Console.WriteLine(GetFullName("Лариса", "Орлова", "Константиновна"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullname = lastName + " " + firstName + " " + patronymic;
            return fullname;
        }
    }
}
