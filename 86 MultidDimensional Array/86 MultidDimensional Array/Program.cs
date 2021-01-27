using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _86_MultidDimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {

                { 1,2,3}, // row 0
                { 4,5,6}, // row 1
                { 7,8,9} // row 2
            };

            // print row 2 index 0
            Console.WriteLine("{0}", array2D[2,0]);

            string[,,] array3D = new string[,,]
                {
                    // Dimnesions have to have the same amount of rows
                    // 2 rows here
                    {
                        { "000", "001"}, // Row 0,0 index 0
                        { "010", "011"} // row 0,1, index 0
                    },

                    // Dimnesions have to have the same amount of rows
                    // 2 rows here
                    {

                        {"100", "101"}, // row 1,0 index 0
                        { "110", "111"} // row 1,1, index 0
                    }

                }; 
            
            // access row 1,1 index 0
            Console.WriteLine("{0}", array3D[0,1,1]);

           

            // create an array with 3 rows and 2 set of values in each row
            string[,] array2DString = new string[3, 2]
                {
                    { "one", "two"},
                    { "theww", "four"},
                    {"five", "six" }
                };

            // replace row 1 index 1 value with chicken
            array2DString[1, 1] = "Chicken";
             Console.WriteLine("{0}", array2DString[1, 1]);




             // find number of dimensions in an array with this code
            int dimensions = array2DString.Rank;
           


            Console.ReadKey();
        }
    }
}
