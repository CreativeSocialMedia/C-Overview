using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _76_Properies_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();

            myBox.Length(5);
            myBox.Width(3);
            myBox.Height=4;


            Console.WriteLine("Volume is: " + myBox.Volume());
            

            Console.ReadKey();
        }
    }
}
