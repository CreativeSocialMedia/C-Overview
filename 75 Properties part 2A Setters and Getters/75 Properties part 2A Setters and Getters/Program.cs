using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _75_Properties_part_2A_Setters_and_Getters
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new "Box" object and assign the "myBox" variable to ti
            Box myBox = new Box();

            // call "setDimension()" method to declare values for the dimensions
            myBox.setDimensions(3,4,5);


            Console.WriteLine("The lenght of the box is: " + myBox.Length());
            Console.WriteLine("The volume of the box is: " + myBox.Volume());

            myBox.DisplayInfo();
            Console.ReadKey();

        }
    }
}
