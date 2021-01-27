using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _71_Obj_Oriented_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
           

                // create an object of my Human class
                // an instance of Huma class
                Human jediAvatar = new Human();

                // access public variables from outside classes in this case Human class
                jediAvatar.firstName 
                = "Yoda";

            jediAvatar.lastName = "Skywalker";
            jediAvatar.introduceMyself();

            jediAvatar.guessMyAge();



            Console.ReadKey();
        
        }
            
    }
}
