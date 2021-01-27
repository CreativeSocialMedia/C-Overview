using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _76_Properties_Part2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();

            myBox.Length=3;
            myBox.Height=4;
            myBox.Width = 10;

            // to call a method in this argument it has to be an int
            Console.WriteLine("volume = " + myBox.Volume);
 

            Console.ReadKey();





        }
    }
}
