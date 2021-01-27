using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_Using_Constructors
{

    class Human
    {
        // declare public member varaibles
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        // default constructor
        public Avatar()

            {
                Console.WriteLine("Constructor called. Object created!");
            }



        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            // this.lastName means take the "lastName" public varaible of the Human class ("This" refers to Human class) 
            // and make it a local member varaible and use it as a new variable
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;


        }

        public void introduceMyself()
        {
            Console.WriteLine("Hi I am Jedi Master {0} {1}. I am {2} years old with {3} eyes!", firstName, lastName, age, eyeColor);
           
        }
    }
}
