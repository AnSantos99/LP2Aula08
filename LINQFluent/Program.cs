using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read lines from file
            string[] rFile = 
                File.ReadAllLines("C:/Users/ansan/Desktop/text.txt");

            // get lines number of lines from text
            int linhas30 = rFile.Count(s => s.Length > 30);

            // Print the result of how many line it exists
            Console.WriteLine($"Nº linhas > 30 = {linhas30}");

            // Find out the average chars on each line
            double avgCharsPerLine = rFile.Select(s => s.Length).Average();

            // Print out the result
            Console.WriteLine($"Media de chars por linha = {avgCharsPerLine}");

            // Check if there is any line bigger than 120
            bool biggerThan = rFile.Any(s => s.Length > 120);

            // Print out the result
            Console.WriteLine($"Linha maior que 120? = {biggerThan}");

            IEnumerable<string> stuff = 
                rFile.Where(s => s.Contains("Y"))
                .Select(s => s?.Split()? [0].ToUpper());

            foreach (string s in stuff) 
            {
                Console.WriteLine(s + " ");
            }


            /*
            // Read all lines
            foreach(string s in rFile) 
            {
                Console.WriteLine(s);
            }*/

            
           
        }
    }
}
