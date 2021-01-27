using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _58_if_statement_ternary_exercise
{
    class Program
    {


        static void Main(string[] args)
        {
            checkTemp();

            Console.Read();

        }



        public static void checkTemp()
        {

            int number;

            string tempComfort;

            string userInput;


            Console.WriteLine("Please enter the temperature in degress Celsius:");
            userInput = Console.ReadLine();

            bool tempInput = int.TryParse(userInput, out number);

            if (tempInput)
            {
                tempComfort = number <= 15 ? "It's too cold!" : number >= 16 && number <= 28 ? "It's too hot!" : "It's ok";
                Console.WriteLine("It is {0}", tempComfort);
            }
            else
            {

                Console.WriteLine("Enter Valid number. Start Again!");
            }





        }




    }
}
