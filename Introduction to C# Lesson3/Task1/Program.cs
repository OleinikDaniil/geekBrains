using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали.
            string[,] diagonalMass = { {"This ", "O", "O", "O" }, {"O", "task ", "O", "O" }, { "O", "O", "is ", "O" }, { "O", "O", "O", "done" } };
            for (int i = 0, j = 0; i < diagonalMass.GetLength(0); i++, j++ )
            {
                Console.Write($"{diagonalMass[i, j]}");
            }
            Console.WriteLine();

            //Написать программу — телефонный справочник — создать двумерный массив 5 * 2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ e - mail.
            //Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).
            //* «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

        }
    }
}
