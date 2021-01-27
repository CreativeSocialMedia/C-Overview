using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _90_Using_Arrays_as_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 15,13,8,12,6};
            double averageResult = GetAverage(studentGrades);

            foreach (int grade in studentGrades)
            {
                Console.WriteLine("Each grade is: {0}", grade);
            }

            Console.WriteLine("the average is :{0}", averageResult);

            Console.ReadKey();



        }

        // create a method to calculate the average of the grades in the array
        // create an array as a parameter in the method
        static double GetAverage(int[] gradesArray)
        {
            // create a variable for the length of the array for easy calculation
            int size = gradesArray.Length;

        
            double average;
            int sum = 0;

            // create a loop that gets the sume of all the grades in the array
            for (int i = 0; i < size; i++)
            {

                sum += gradesArray[i];

            }
            // average = sum of the array values / by the length (number of values in the array)
            average = (double)sum / size;
            return average;

        }


    }
}
