using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _88_Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // normal array
            // index                       0    1    2    3
            // normal array of type int: [15],[21],[56],[89]

            // Jagged Array
            // index                             0                   1                   2               
            // jagged array of type int: [array1[]15,[6],[80],[200]],[array2[52],[60],[3],[400]]


            // declare a jaggedarray with 3 rows // 3 steps
            // Step1:
            int[][] jaggedArray = new int[3][];


            // initialize the jaggedArray variable with index length for each row
            // step 2:
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[1] = new int[2];

            // initialize the jaggedArra variable with values for each row
            // Step 3:
            jaggedArray[0] = new int[] { 2, 3, 5, 8, 20 };
            jaggedArray[1] = new int[] { 6,8,10 };
            jaggedArray[2] = new int[] { 20,40 };


            ////////// alternative to initialize arrays 
            /// this method does not assign a variable name to the array
            /// it simply initializes the array and adds values to each row
            int[][] jaggedArray2 = new int[][]
                {
                    // element 1
                    new int[] { 2,4,6,8,1,20},
                    //element 2
                    new int[]{1,2,3}
                };

            Console.WriteLine("value of first entry is: {0}", jaggedArray2[0][2]);

            // 
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                // display # element
                Console.WriteLine("Element at pos {0}", i);

                // display each value from each element
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
                }
            }

            Console.ReadKey();

        }
    }
}
