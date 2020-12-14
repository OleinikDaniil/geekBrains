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
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine("Введите минимальную дневную температуру");
            string minTemp = Console.ReadLine();
            int minTempInt = Convert.ToInt32(minTemp);
            Console.WriteLine("Введите максимальную дневную температуру");
            string maxTemp = Console.ReadLine();
            int maxTempInt = Convert.ToInt32(maxTemp);
            int medianTempInt = (maxTempInt + minTempInt) / 2 ;
            Console.WriteLine( "Средняя температура за день равна: " + medianTempInt + " градусов.");
        }
    }
}
