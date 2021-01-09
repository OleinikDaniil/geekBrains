using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string testDir = @"C:\Users\ПК\Desktop\geekBrains\Introduction to C# Lesson5\Task3";
            string[] entries = Directory.GetFileSystemEntries(testDir, "*",
SearchOption.AllDirectories);
            string noRecurFile = "noRecurse.txt";
            string recurFile = "recurse.txt";
            System.IO.DirectoryInfo rootDir = new System.IO.DirectoryInfo(testDir);
            //с рекурсией
            WalkDirectoryTree(rootDir, recurFile);
            // без рекурсии
            while (true)
            {
                File.WriteAllText(noRecurFile, "");
                for (int i = 0; i < entries.Length; i++)
                {
                    File.AppendAllText(noRecurFile, entries[i]);
                    File.AppendAllText(noRecurFile, Environment.NewLine);
                }
                break;
            }
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root, string txtFile)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            files = root.GetFiles("*.*");

            if (files != null)
            {
                foreach (System.IO.FileInfo file in files)
                {
                    File.AppendAllText(txtFile, file.FullName);
                    File.AppendAllText(txtFile, Environment.NewLine);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo, txtFile);
                }
            }
        }
    }
}
