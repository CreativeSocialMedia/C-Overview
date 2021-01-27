using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_Properties_Part2B
{
    class area
    {

        // declare private member variables
        private int length;
        private int height;
        private int surface;


        // create properties to give private member variables public access outside this class
        // and set contisions and methods for each
        public int Length { get; set; }

        public int Height { get; set; }

        public int Area{
            
          get 
        {
            return surface = height*length;
        }

}

        public area(int length, int height)
        {

            this.length = length;
            this.height = height;

        }


    }
}
