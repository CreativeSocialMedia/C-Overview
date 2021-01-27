using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _65_break_and_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 
             * /// if you use break its stops the loop when condition is met
             * 
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    // we can use breaks in for loop to get out of the loop when condition is met
                    break;
                }
                
            }
            */

            
           /// if you use continue it continue until contition is met.
         
          for (int counter = 0; counter < 10; counter++)
          {
             // each time we hit an odd number continue the loop until condition is met
              if (counter %2 == 0)
              {
                  Console.WriteLine("here are odd numbers:");
                // we can use breaks in for loop to get out of the loop when condition is met
                continue;
              }

              Console.WriteLine(counter);
          }
          


            Console.Read();
        }
    }
}
