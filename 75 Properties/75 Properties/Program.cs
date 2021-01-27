using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _75_Properties
{

    // this is an exercise in the fundamentals of properties 


    class Program
    {
        static void Main(string[] args)
        {
            // create a new "Box" object and assign the "myBox" variable to ti
            Box myBox = new Box();

            // take the "Box" class variables and assign values to them
            myBox.length = 3;
            myBox.width = 4;
            myBox.height = 5;

            myBox.DisplayInfo();

            Console.ReadKey();
        }
      
    } 
}
