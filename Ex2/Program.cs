using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"in.txt";
            int length = 10;
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                file.Create();
            }
            using (StreamWriter swFile = new StreamWriter(path))
            {
                Random rnd = new Random();
                for (int i = 0; i < length; i++)
                {
                    swFile.WriteLine("{0}", rnd.Next(100));
                }
            }
            int sum = 0;
            using (StreamReader srFile = new StreamReader(path))
            {
                for (int i = 0; i < length; i++)
                {
                    sum += Convert.ToInt32(srFile.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел из файла {0} равна {1}", path, sum);
            Console.ReadKey();
        }
    }
}
