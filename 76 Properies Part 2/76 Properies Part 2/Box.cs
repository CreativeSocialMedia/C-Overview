using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_Properies_Part_2
{
    class Box
    {
        // member variable
        private int length;
        private int width;
        private int height;
        private int volume;


        // shorthand get and set member variable and method with the property named "Height"
        // the property Heigth is the gateway for access to height

        /* 
        
        public void Length(int length)
            {
                this.length = length;
            }
             
             */

        // this is alternate / shorthand method of the above using get and set method Property
        // Here you are declaring the member variable so that it can be accessed outside this class and giving it a get and set method with conditional statement for value given in the program to run 
        // Always CAPITALIZE PROPERTY NAMES
        public int Height
        {
            get
            {
                return height;
            }

            set
            {

                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }

            }

        }

        // this is long hand version of above a method that allows acces to change value outside the class or in another class
        // Always CAPITALIZE PROPERTY NAMES
        public void Length(int length)
        {
            this.length = length;
        }


        // this is long hand version of above a method that allows acces to change value outside the class or in another class
        // Always CAPITALIZE PROPERTY NAMES
        public void Width(int width)
        {
            this.width = width;
        }

        // this is a calculation method that returns an int value
        // Always CAPITALIZE PROPERTY NAMES
        public int Volume()
        {
            return length * width * height;
        }

      

    }
}
