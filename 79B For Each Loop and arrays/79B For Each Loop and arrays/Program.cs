using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _79B_For_Each_Loop_and_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            // this is a for loop assigning indexes to value
            // indexes count is equal to value
            for (int i = 0; i < 10; i++)
            {
               // nums[i] = i;

                // can also be 
                nums[i] = i + 10;
            }

            // this is a for loop assigning value to the nums loop i
            // use this: for (int j = 0; j < 10; j++)
            // or this
            // in this loop J is an int that is not of the same dataType as nums array
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j , nums[j]);
            }



            // in FOR EACH loop the K is the same datatype as the nums value and index
            int counter = 0;
            // this means int K is the current value for nums starting from 0 index
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k); counter++;
            }


            Console.ReadKey();
        }
    }
}
