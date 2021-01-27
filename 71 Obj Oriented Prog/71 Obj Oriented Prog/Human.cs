using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_Obj_Oriented_Prog
{
    class Human
    {
        // create a public mamber variable
        public string firstName;
        public string lastName;
        public int ageGuess;
        public int age;
        public int num;
        public string input;
       
        // create a method for the meber varaible

        public void introduceMyself()
        {
            Console.WriteLine("Welcome Jedi counsil training, I am {0} {1}", firstName , lastName);
            Console.WriteLine("I am your jedi master! Learn c# you will!");
       
        }

      


        public void guessMyAge()
        {
            Console.WriteLine("Can you guess my age?");
           input = Console.ReadLine();

           bool ageGuess = int.TryParse(input, out age);

            if (ageGuess)
            {
                num = age;


                guessCorrect();

               
            }

            else
            {
                Console.WriteLine("enter digits! start again!");
                guessMyAge();
            }

        }

        public void guessCorrect()
        {
            if (input == "900")
            {
                Console.WriteLine("You guessed right!");
            }

            else
            {
                Console.WriteLine("Use the force to guess it! Try again!");
                guessMyAge();
            }

        }

        
    }
}
