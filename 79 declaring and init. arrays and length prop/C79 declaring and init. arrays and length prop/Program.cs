using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C79_declaring_and_init.arrays_and_length_prop
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a new array called "grades" and assign a length of 5 indexes
            int[] grades = new int[5];

            // assigning values to the 5 indexes
            // indexes always start at 0
            grades[0] = 20;
            grades[1] = 10;
            grades[2] = 30;
            grades[3] = 40;
            grades[4] = 50;
           
          //Example 1:////////////////////////////

            // to acces the array
            Console.WriteLine("grade at index 0: {0}", grades[0]);



            //Examples 2://///////////////////////////
            Console.WriteLine("Enter a grade!");
            string input = Console.ReadLine();


            // assign input value to grade[0] index
            grades[0] = int.Parse(input);

            // to acces the array
            Console.WriteLine("grade at index 0: {0}", grades[0]);



            //Example 3: ///////////
            // a thrid way of initializing array
            int[] gradeOfStudents = { 20, 13, 5, 8, 20 };

            // example4:////////////
            // a fourth way to initialize an array
            int[] mathStudentGrades = new int[] { 2, 6, 8, 10, 20 };

            Console.WriteLine("Length of grades: {0}", mathStudentGrades.Length);


            Console.ReadKey();

        }
    }
}
