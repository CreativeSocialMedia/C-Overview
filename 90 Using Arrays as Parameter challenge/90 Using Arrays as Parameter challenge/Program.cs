using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _90_Using_Arrays_as_Parameter_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // create an array with values
        int[] happiness = { 2, 3, 4, 5, 6, 8, 10, 20 };

        // use the sunisshining method to add the "happiness" array as an argument
        /*Arrays are a reference type in C#. This means that each time an array is passed 
         as an argument to any function, the reference (or pointer) to the argument is 
         passed to the function. Thus any modifications you make to the array in the 
         function are made in the actual argument also*/
        SunIsShining(happiness);


            //list the caculation for each element here
            foreach (int y in happiness)

            {
                Console.WriteLine(y);


            }

            Console.ReadKey();

        }

        // create a method to count each element in the array
        static void SunIsShining(int [] x)
        {

            for (int i= 0; i < x.Length; i++)
            {
                x[i] += 2;

            }
        }
    }
           
}
