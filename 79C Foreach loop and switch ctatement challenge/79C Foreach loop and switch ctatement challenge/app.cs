using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79C_Foreach_loop_and_switch_ctatement_challenge
{
    class app
    {
        private int number;
        private int caseSwitch;

        public int Number
        {

            get
            {
                return number;
            }

            set
            {

                number = value;
            }
        }


        public void start()
        {

       
            Console.WriteLine("Please Enter a value:");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            string input = Console.ReadLine();

            bool Number = int.TryParse(input, out caseSwitch);

            if (Number)

            {
                if (caseSwitch > 0 && caseSwitch <= 3)
                {
                    number = caseSwitch;
                }
            }

            else
            {
                Console.WriteLine("That didn't work!");
            }

            switch (caseSwitch)
            {

                case 1:
                    
                    Console.WriteLine("It's a String!");
                    break;

                case 2:
                    Console.WriteLine("It's a Int!");
                    break;

                case 3:
                    Console.WriteLine("It's a Bollean!");
                    break;
                default:
                    Console.WriteLine("Please enter correct value!");
                    start();
                    break;

            }


        }
      
    }
}
