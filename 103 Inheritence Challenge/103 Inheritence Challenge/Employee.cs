using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_Inheritence_Challenge
{
    class Employee
    {
 
        // properties
        // protected means it is accesible only by this class or any deriving classes
        
        public string Name { get; set; }
        public string FirstName { get; set; }
         public int Salary { get; set; }
       


        // instance of constructor // declare variables as the parameters here
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;

        }

        // this is an empty const
        public Employee() {
            Name = "Panjuta";
            FirstName = "Denis";
            Salary = 50000;
        }

        public void Work() {
            Console.WriteLine("I'm working!");
        }

        public void Pause()
        {
            Console.WriteLine("I'm taking a break!");
        }

      

    }
}
