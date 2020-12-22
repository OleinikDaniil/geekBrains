using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] battlefield = new char[12, 12];
            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    if ((i == 0)||(j == 0)||(i == 11)||(j == 11))
                    {
                        battlefield[i, j] = '+';
                    } else
                    {
                        battlefield[i, j] = 'O';
                    }

                }
            }
            ChangeArrayElements(battlefield, 4);
            ChangeArrayElements(battlefield, 3);
            ChangeArrayElements(battlefield, 3);
            ChangeArrayElements(battlefield, 2);
            ChangeArrayElements(battlefield, 2);
            ChangeArrayElements(battlefield, 2);
            ChangeArrayElements(battlefield, 1);
            ChangeArrayElements(battlefield, 1);
            ChangeArrayElements(battlefield, 1);
            ChangeArrayElements(battlefield, 1);
            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    System.Console.Write($"{battlefield[i, j]} ");
                }
                System.Console.WriteLine();
            }

        }

        static void ChangeArrayElements(char[,] matrix, int shipSize)
        {
            Console.WriteLine($"Создаем корабль размером " + shipSize);
            Console.WriteLine("Задайте направление: Вниз('d') или Вправо ('r')");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Задайте координату начала отсчета корабля по вертикали (1 - " + (11 - shipSize) + ")");
            string userCoordX = Console.ReadLine();
            int convertCoordX = Int32.Parse(userCoordX);
            Console.WriteLine($"Задайте координату начала отсчета корабля по горизонтали (1 - " + (11 - shipSize) + ")");
            string userCoordY = Console.ReadLine();
            int convertCoordY = Int32.Parse(userCoordY);
            if (userInput == "d")
            {
                for (int i = 0; i < shipSize; i++)
                {
                    matrix[convertCoordX+i,convertCoordY] = 'X';
                }
            }
            if (userInput == "r")
            {
                for (int i = 0; i < shipSize; i++)
                {
                    matrix[convertCoordX,convertCoordY+i] = 'X';
                }
            }
        }
    }
}
