using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _113_Read_From_Textfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // reading a text file example 1:
            string text = System.IO.File.ReadAllText(@"I:\Udemy c#\C# Lessons\C# Overview\113 Read From Textfile\113 Read From Textfile\Assets\TextFile1.txt");

            Console.WriteLine("text files contains: {0}", text);


            // example 2: reads every line
            string[] lines = System.IO.File.ReadAllLines(@"I:\Udemy c#\C# Lessons\C# Overview\113 Read From Textfile\113 Read From Textfile\Assets\TextFile1.txt");

            Console.WriteLine("text files lines are: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();
        }
    }
}
