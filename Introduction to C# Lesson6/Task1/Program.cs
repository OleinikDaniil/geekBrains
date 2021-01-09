using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process instance in processes)
            {
                Console.Write(instance.ProcessName + "  ");
                Console.Write(instance.Id);
                Console.WriteLine();
            }
            Console.WriteLine("Введите имя или ID процесса, чтобы завершить его");
            string processInput = Console.ReadLine();
            try
            {
                int processId = Int32.Parse(processInput);
                foreach (Process instance in processes)
                {
                    if (instance.Id == processId)
                    {
                        instance.Kill();
                    }
                }
            }
            catch
            {
                foreach (Process instance in processes)
                {
                    if (instance.ProcessName == processInput)
                    {
                        instance.Kill();
                    }
                }
            }
        }
    }
}
