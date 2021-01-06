using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToLongTimeString();
            string filename = "startup.txt";
            File.AppendAllText(filename , time);
            File.AppendAllText(filename , Environment.NewLine);
        }
    }
}
