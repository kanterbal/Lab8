using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine("Имя основного каталога: {0}", path);
            Console.WriteLine("Входящие в него каталоги:");
            foreach (DirectoryInfo dirName in dir.GetDirectories())
            {
                Console.WriteLine("Имя каталога: {0}",dirName.Name);
                Console.WriteLine("Содержимое подкаталога {0}:", dirName.Name);
                Console.WriteLine("Каталоги:");
                foreach (DirectoryInfo subDirName in dirName.GetDirectories())
                {
                    Console.WriteLine(subDirName.Name);
                }
                Console.WriteLine("Файлы:");
                foreach (FileInfo fileName in dirName.GetFiles())
                {
                    Console.WriteLine(fileName.Name);
                }
                Console.WriteLine("-----");
            }
            Console.ReadKey();
        }
    }
}
