using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную дневную температуру");
            string minTemp = Console.ReadLine();
            int minTempInt = Convert.ToInt32(minTemp);
            Console.WriteLine("Введите максимальную дневную температуру");
            string maxTemp = Console.ReadLine();
            int maxTempInt = Convert.ToInt32(maxTemp);
            int medianTempInt = (maxTempInt + minTempInt) / 2;
            Console.WriteLine("Средняя температура за день равна: " + medianTempInt + " градусов.");
            Console.WriteLine("Введите номер месяца от 1 до 12");
            string monthInput = Console.ReadLine();
            int monthInputInt = Convert.ToInt32(monthInput);
            string monthName = "";
            bool winterIsHere = false;
            switch (monthInputInt)
            {
                case 1:
                    monthName = "Январь";
                    winterIsHere = true;
                    break;
                case 2:
                    monthName = "Февраль";
                    winterIsHere = true;
                    break;
                case 3:
                    monthName = "Март";
                    break;
                case 4:
                    monthName = "Апрель";
                    break;
                case 5:
                    monthName = "Май";
                    break;
                case 6:
                    monthName = "Июнь";
                    break;
                case 7:
                    monthName = "Июль";
                    break;
                case 8:
                    monthName = "Август";
                    break;
                case 9:
                    monthName = "Сентябрь";
                    break;
                case 10:
                    monthName = "Октябрь";
                    break;
                case 11:
                    monthName = "Ноябрь";
                    break;
                case 12:
                    monthName = "Декабрь";
                    winterIsHere = true;
                    break;
            }
            Console.WriteLine(monthName);

            if ((winterIsHere == true) && (medianTempInt > 0))
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
