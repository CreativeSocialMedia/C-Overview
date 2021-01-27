using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _79C_Foreach_loop_and_switch_ctatement_challenge
{
    class Program
    { 
          
        static void Main(string[] args) 
            
       
        {
               // declare variables
            Boolean valid = false;
            string inputValueType;
          
            int number;
            int caseSwitch;

            // get first user input
            Console.WriteLine("Enter a value: ");
            string inputValue = Console.ReadLine();

            // ask for 2nd user input
            Console.WriteLine("Select to validate your input dataType!");
            Console.WriteLine("Enter 1 for string!");
            Console.WriteLine("Enter 2 for Int!");
            Console.WriteLine("Enter 3 for Bool!");

            Console.WriteLine("Enter: ");

            // convert value into int
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {

                case 1:
                    // check for string is valid
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    Console.WriteLine("It's a String!");
                    break;

                case 2:
                    int retValue = 0;
                    // check for int
                    valid = int.TryParse(inputValue, out retValue);
                    inputValue = "Integer";
                    Console.WriteLine("It's a Int!");
                    break;

                case 3:
                    bool retFlag = false;
                    // check for boolean
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValue ="Boolaen";
                    Console.WriteLine("It's a Boolean!");
                    break;

                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Please enter correct value!");
                  
                    break;

               }

                bool IsAllAlphabetic(string value)
            {
                // this foreach loop checks each letter in the vlaue entered by user to see if they are all letters only
                // example: Hello world // results in true
                // example 2: H3llo W0rld! // result is false because of the 3 and the 0
                foreach (char c in value)

                {
                    // if false
                    if (!char.IsLetter(c))
                        return false;
                }
                // if true do this
                return true;
            }

            Console.WriteLine("You enters : {0}", inputValue);

            if (valid)
            {

                Console.WriteLine("It is valid: {0}", inputType);



            }

            else
            {

                Console.WriteLine("It Is an invalid : {0}", inputType);
            }

                Console.ReadKey();
        }   

     
    }
}
