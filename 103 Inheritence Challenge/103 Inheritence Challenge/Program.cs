using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _103_Inheritence_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 4000000);

            // these  methods read data from themselves in the  Employee class
            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 999999999);


            // this Lead() method reads data from itself in the Boss class
            chuckNorris.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000 );

            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}
