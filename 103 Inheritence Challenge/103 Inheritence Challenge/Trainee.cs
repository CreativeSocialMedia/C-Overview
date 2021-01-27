using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_Inheritence_Challenge
{
    class Trainee:Employee
    {

        public int WorkingHours { get; set; }

        public int SchoolHours { get; set; }

        // create a trainee constructo
        public Trainee(int workingHours, int schoolHours, string name, string firstName, int salary) : base(name, firstName, salary)

        {

            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;


        }

        public void Learn() {

            Console.WriteLine("I'm learing to be a Jedi! I have {0} school Hours!", SchoolHours);
        }

        public void Work()
        {

            Console.WriteLine("Jedi must practice {0} school Hours!", WorkingHours);
        }

    }
}
