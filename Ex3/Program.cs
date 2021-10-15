using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "in.txt";
            using (StreamReader srFile = new StreamReader(path))
            {
                Console.WriteLine("Количество символов в тексте: {0}", srFile.ReadToEnd().Length);

            }
            using (StreamReader srFile = new StreamReader(path))
            {

                string[] strArray = srFile.ReadToEnd().Split('\n');
                Console.WriteLine("Количество строк в тексте: {0}", strArray.Length);
            }
            using (StreamReader srFile = new StreamReader(path))
            {
                string[] strArray = srFile.ReadToEnd().Split();

                int count = 0;
               
                foreach (var str in strArray)
                {
                    if (str != "")
                    {
                        count++;
                    }

                }
                Console.WriteLine("Количество слов в тексте: {0}", count);
            }
            Console.ReadKey();
        }
    }
}
