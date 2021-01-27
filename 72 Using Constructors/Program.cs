using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _72_Using_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human avatarYoda = new Human("Yoda", "Skywalker", "Blue", 900);
            avatarYoda.introduceMyself();
        

            Console.WriteLine("---------------------------------");
            
            Human basicHuman = new Human();
              basicHuman.introduceMyself();

            Console.ReadKey();
        }

       
    } 
}
