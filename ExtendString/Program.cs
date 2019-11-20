using System;
using System.Text;

namespace ExtendString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ahahahhahahahah";
            Console.WriteLine(a.ToRandomCase());
        }
    }


    /// <summary>
    /// Extension class of String
    /// </summary>
    public  static class StringExtension 
    {

        /// <summary>
        /// Method extension to class string
        /// </summary>
        /// <param name="s"> To "say" its of class</param>
        /// <returns> returns stringbuilder s</returns>
        public static string ToRandomCase(this String s) 
        {
            // instance of type stringbuilder
            StringBuilder sb = new StringBuilder();

            // instance of type Random
            Random rnd = new Random();

            // Percorre todos os chars de uma string
            foreach (char i in s) 
            {
                string cUpOrLow = i.ToString();

                if (rnd.NextDouble() > 0.5)
                {
                    sb.Append(cUpOrLow.ToLower());
                }

                else 
                {
                    sb.Append(cUpOrLow.ToUpper());
                }   
            }
            return sb.ToString();
        }
    }
    
}
