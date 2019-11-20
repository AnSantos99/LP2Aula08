using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LINQQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get file and read all lines
            string[] lines = 
                File.ReadAllLines("C:/Users/ansan/Desktop/text.txt");

            // Counts lines who are longer than 30 chars using LINQ query
            int linhas30 =
                (from s in lines
                 where s.Length > 30
                 select s).Count();

            // Gets average chars in each line using LINQ query by getting
            // the lenght of the line
            double avgCharsPerLine =
                (from s in lines
                 select s.Length).Average();

            // Gets lines that are longer than 120 chars
            bool linhaLenght =
                (from s in lines
                 where s.Length > 120
                 select s).Any();

            // Gets lines that start with Y
            IEnumerable<string> stuff =
                from s in lines
                where s.Contains("Y")
                select s.Split()?[0].ToUpper();

            // Print out number of lines longer than 30 chars
            Console.WriteLine(linhas30);

            // Print out number of average char per line
            Console.WriteLine(avgCharsPerLine);

            // Check out whole text file for upper Y and print the word out
            foreach (string s in stuff)
            {
                Console.WriteLine(s + " ");
            }




        }
    }
}
