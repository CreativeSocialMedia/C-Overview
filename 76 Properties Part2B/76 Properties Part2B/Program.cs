using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _76_Properties_Part2B
{
    class Program
    {
        static void Main(string[] args)
        {

            Box myBox = new Box(10,20,30);

            Console.WriteLine("this volume = {0}", myBox.Volume);

            area myArea = new area(60,80);

            Console.WriteLine("the area = {0}", myArea.Area);

            Console.ReadKey();
        }
    }
}
