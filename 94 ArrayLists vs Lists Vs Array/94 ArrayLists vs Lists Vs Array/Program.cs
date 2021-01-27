using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _94_ArrayLists_vs_Lists_Vs_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // immutable - limited to one data type
            int[] scores = new int[] {100,120,160,180,200 };

            // immutable - limited to one data type
            List<int> list = new List<int> {2,4,6,8,10,20 };


            // these add new elements with values to end of the array list
            list.Add(0);
            list.Add(32);

            // sort the values in ascending order
            list.Sort();

            // remove 2 elements starting from the 3rd index 
            list.RemoveRange(3,2);


            // create a for loop that shows the value of each element using i as a counter
            foreach (int i in list)
            {

                Console.WriteLine(i);

            }



            // determines if the value of 4 is in the list
            Console.WriteLine(list.Contains(4));


            // we would like to know the index of that 4
            // this lumbar expression checks to see where the value of four is 
            int index = list.FindIndex(x=> x == 4);
            //and returns the index of the element containing the value "4"
            Console.WriteLine(list[index]);

            // remove element at index
            list.RemoveAt(index);

            // this lists the whole list
            list.ForEach(i => Console.WriteLine(i));


            // creating an ArrayList 
            // ArrayList can contain different type of data types
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            arrayList.Add(1);
            arrayList.Add("You are becoming a powerfull Jedi!");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4});

            foreach (Object o in arrayList)
            {

                Console.WriteLine(o);
            }

            Console.ReadKey();
        }
    }


    class Number
    {
        public int n { get; set; }

        // create a method to override returning a string for value of n
        // value of n should be int 4 from line 64 above
        // otherwise without this methog the n will return the name of the app by default
        public override string ToString()
        {
            return n.ToString();
        
        }


    }
}
