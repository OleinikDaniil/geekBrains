using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу — телефонный справочник — создать двумерный массив 5 * 2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ e - mail.
            string[,] phonebook = { { "Вася", "89005007060" }, { "Петя", "89005006060" }, { "Коля", "89005008060" }, { "Саша", "89005009060" }, { "Даша" , "89005005060" } };
            Console.WriteLine("Введите имя человека, чтобы получить его номер телефона");
            string callName = Console.ReadLine();
            bool isPresent = false;
            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                if (phonebook[i , 0] == callName)
                {
                    Console.WriteLine($"{phonebook[i, 1]}");
                    isPresent = true;
                    break;
                }
            }
            if (!isPresent)
                Console.WriteLine("Номера нет");
        }
    }
}
