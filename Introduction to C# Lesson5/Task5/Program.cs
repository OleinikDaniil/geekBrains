using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void showTaskList(ToDo[] taskMassive)
        {
            for (int i = 0; i < taskMassive.Length; i++)
            {
                Console.Write($"{i + 1}" + " ");
                Console.Write(taskMassive[i].Title);
                if (taskMassive[i].IsDone)
                {
                    Console.Write(" X");
                };
                Console.WriteLine();
            }
        }
        static ToDo[] ChangeTasks ()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ToDo[]));
            using (FileStream fs = new FileStream("tasks.xml", FileMode.OpenOrCreate))
            {
                ToDo[] xmlDeserial = (ToDo[])formatter.Deserialize(fs);
                Console.WriteLine("Список задач:");
                showTaskList(xmlDeserial);
                Console.WriteLine("Введите номер задачи, чтобы пометить ее как выполненную");
                int taskCompleted = Int32.Parse(Console.ReadLine());
                xmlDeserial[taskCompleted - 1].IsDone = true;
                showTaskList(xmlDeserial);
                return xmlDeserial;
            }
        }
        static void Main(string[] args)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ToDo[]));
            //Сериализованные изначальные данные
            /*ToDo task1 = new ToDo("Протереть пыль", false);
            ToDo task2 = new ToDo("Подмести пол", false);
            ToDo task3 = new ToDo("Загуглить решение задач", true);
            ToDo[] xmlSerial = { task1, task2, task3 };
            using (FileStream fs = new FileStream("tasks.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, xmlSerial);
            }*/
            ToDo[] forSerial = ChangeTasks();
            using (FileStream fs = new FileStream("tasks.xml", FileMode.Create))
            {
                formatter.Serialize(fs, forSerial);
            }
        }
    }
}
