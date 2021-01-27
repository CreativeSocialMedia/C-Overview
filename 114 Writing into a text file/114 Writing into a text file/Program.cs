using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _114_Writing_into_a_text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // writing into a text file Method 1:
            string[] lines = { "First line", "secone line", "third Line", "250", "20000", "380" };
            File.WriteAllLines(@"I:\Udemy c#\C# Lessons\C# Overview\114 Writing into a text file\114 Writing into a text file\Assets\TextFile2.txt", lines);


            // Method 2:
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();

            Console.WriteLine("Please enter text for file");
            string input = Console.ReadLine();

            File.WriteAllLines(@"I:\Udemy c#\C# Lessons\C# Overview\114 Writing into a text file\114 Writing into a text file\Assets\TextFile2.txt", lines);



            // Method 3:
            using (StreamWriter file = new StreamWriter(@"I:\Udemy c#\C# Lessons\C# Overview\114 Writing into a text file\114 Writing into a text file\Assets\TextFile3.txt"))
            {
                foreach(string line in lines)
                {

                    if (line.Contains("2"))
                    {

                        file.WriteLine(line);
                    }
                }

            }

            // this allows to adding a line
            using (StreamWriter file = new StreamWriter(@"I:\Udemy c#\C# Lessons\C# Overview\114 Writing into a text file\114 Writing into a text file\Assets\TextFile3.txt", true))
            {
                file.WriteLine("Additiiona line");
            }
                Console.ReadKey();
        }
    }
}
