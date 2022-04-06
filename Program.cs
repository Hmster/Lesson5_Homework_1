using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------part1 + part2-------");
            //Make file, append date and time, append file by lines.
            Console.WriteLine("Press \"x\" to stop.\nEnter any text below:");
            DateTime now = DateTime.Now;
            string data = string.Empty;
            string filename = "text1.txt";
            FileInfo fileInfo = new FileInfo(filename);

            File.AppendAllLines(filename, new[] {now.ToString()});

            while (data != "x")
            {
                data = Console.ReadLine();
                if (data != "x")
                    File.AppendAllLines(filename, new[] {data});
            }

            Console.WriteLine("Path to file: " + fileInfo.FullName);

            Console.WriteLine("\n-------part3-------");
            Console.WriteLine("Enter numbers(0..255) separated with space:");
            byte[] numbers = Lesson5.GetData(Console.ReadLine());

            File.WriteAllBytes("numbers.bin", numbers);
            fileInfo = new FileInfo("numbers.bin");
            Console.WriteLine("Path to file: " + fileInfo.FullName);
            byte[] fromFile = File.ReadAllBytes(fileInfo.FullName);

            Console.WriteLine("Reading data from: " + fileInfo.FullName);
            for (int i = 0; i < fromFile.Length; i++)
                Console.Write(fromFile[i] + " ");

            Console.ReadKey();
        }
    }
}
