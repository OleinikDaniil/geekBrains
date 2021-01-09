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
            string greeting = Properties.Settings.Default.greeting;
            string name = Properties.Settings.Default.name;
            string age = Properties.Settings.Default.age;
            string occupation = Properties.Settings.Default.occupation;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.name) && !string.IsNullOrEmpty(Properties.Settings.Default.age) && !string.IsNullOrEmpty(Properties.Settings.Default.occupation))
            {
                Console.WriteLine($"{greeting} {name}! Вам {age} лет, ваша профессия - {occupation}");
            }
            else 
            { 
                Console.WriteLine($"{greeting}!"); 
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.name))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.age))
            {
                Console.WriteLine("Введите возраст пользователя:");
                Properties.Settings.Default.age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.occupation))
            {
                Console.WriteLine("Введите профессию пользователя:");
                Properties.Settings.Default.occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
        }

    }
}
