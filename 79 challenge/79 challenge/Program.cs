using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _79_challenge
{
    class Program
    {
        static void Main(string[] args)
        {



            // create an array with five items
            // create a for each loop that lists the item

            string[] myList = {"Maya", "Blender", "Mudbox", "c#", "Unity"};
            

                  
            // create a foreach loop that takes the string Skills and assigns the valuse of myList array
            foreach(string skills in myList)
           
            {
                Console.WriteLine("These ar my jedi skills:{0}", skills);
            }




            ///////////////////////////////////////
     



            Console.ReadKey();
        }
    }
}
