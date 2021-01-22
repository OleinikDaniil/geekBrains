using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца от 1 до 12");
            string seasonInput = Console.ReadLine();
            Season findSeason = SeasonFind(seasonInput);
            Console.WriteLine(SeasonTell(findSeason));
        }

        static Season SeasonFind(string seasonNumber)
        {
            if (seasonNumber == "1" || seasonNumber == "2" || seasonNumber == "12")
                return Season.Winter;
            else if (seasonNumber == "3" || seasonNumber == "4" || seasonNumber == "5")
                return Season.Spring;
            else if (seasonNumber == "6" || seasonNumber == "7" || seasonNumber == "8")
                return Season.Summer;
            else if (seasonNumber == "9" || seasonNumber == "10" || seasonNumber == "11")
                return Season.Autumn;
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                seasonNumber = Console.ReadLine();
                Season correctSeason = SeasonFind(seasonNumber);
                return correctSeason;
            }
        }

        static string SeasonTell(Season enumSeason)
        {
            if (enumSeason == Season.Winter)
                return "Зима";
            else if (enumSeason == Season.Spring)
                return "Весна";
            else if (enumSeason == Season.Summer)
                return "Лето";
            else
                return "Осень";
        }
    }
}
