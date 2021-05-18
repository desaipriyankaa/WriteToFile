using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"F:\PProject\Advanced\File IO\Start\Employee.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            //Reading all lines of file
            foreach(var line in lines)
            {

                Console.WriteLine(line);
            }

            //write data to file
            Console.WriteLine("\n\nEnter data to write in file (name,surname,url): \n");
            string content = Console.ReadLine();
            lines.Add(content);
            File.WriteAllLines(filepath, lines);
            Console.WriteLine("\nFile updated....");
            foreach (var line in lines)
            {

                Console.WriteLine(line);
            }
        }
    }
}
