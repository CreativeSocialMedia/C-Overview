using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _89___Jagged_Array_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 3 jagged array which contain 3 "animal arrays", in which 2 animals should be stored
            // list different animals from different arrays

            string[][] animalArray = new string[][]
            {

            new string[] { "Lion", "Tiger", "Pantrher" },
            new string[] { "Mokey", "Gorilla", "orangatang" },
            new string[] { "Beaver", "Otter", "Squirrel" },
            
            };


            Console.WriteLine("We have a {0}, and a {1} in the zoo!", animalArray[0][1], animalArray[2][2]);
            Console.ReadKey();
        }

        
    }
}
