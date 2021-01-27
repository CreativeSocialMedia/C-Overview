using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_Properties
{
    class Box
    {
        // Declare public member varaibles
        // this is for demno purpose only because it is an insecure code
        // member variables should not be public; this is for demo purpose only

        public int length;
        public int width;
        public int height;
        public int volume;

        public void DisplayInfo()
        {
            // version 1 - no method needed
            // Console.WriteLine("The length is {0} + the Width {1} + the height {2} is equal to the Volume {3}", length, width, height, volume = length*width*height);

            // version 2 with method
            Console.WriteLine("The length is {0} + the Width {1} + the height {2} is equal to the Volume {3}", length, width, height, calcVolume());

            

        }

        // method for version 2 on line 25
        public int calcVolume()
        {

            return length * width * height;
        }

       

    } 
}
