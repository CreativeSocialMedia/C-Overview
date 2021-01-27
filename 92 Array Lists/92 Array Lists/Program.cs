using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _92_Array_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // first add the"using System.Collections" library at the top

            // declare an arrayList with an undefined amount if objects
            ArrayList myArrayList = new ArrayList();

            // declare an arrayList with a defiend amount if objects
            ArrayList myArrayList2 = new ArrayList(100);


            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);


            // delete element with specific value from the array list
            myArrayList.Remove(13);
            myArrayList.Remove(13);
            myArrayList.Remove(13);
           

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;


            // Object is uses because the array has different data types
            // and Object should be used with arrays that have various data types
            foreach (Object obj in myArrayList)
            {
                // check if obj is an int
                if (obj is int)
                {
                    // if so need to convert the obj to double and add to the sum
                }

                // if obj is a double int
                else if (obj is double)
                {
                    // cast obj to a double and add to the sum
                    sum += (double)obj;
                }

                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }

                Console.WriteLine(sum);

                Console.ReadKey();

            }

        }
    }
}
