using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_Inheritence_Challenge
{
    class Boss:Employee
    {
        public string CompanyCar { get; set; }


        public Boss(string companyCar, string name, string firstName, int salary):base(name, firstName,salary)
        {

            this.CompanyCar = companyCar;

            /* when you use "base" on line 14 it replaces this 
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            */

        }

        public void Lead()
        {

            Console.WriteLine("My name is {0} {1} and I'm the boss!", FirstName, Name);
        }
       

    }
}
