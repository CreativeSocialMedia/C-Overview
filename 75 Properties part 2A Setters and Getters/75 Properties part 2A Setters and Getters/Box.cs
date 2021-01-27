using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_Properties_part_2A_Setters_and_Getters
{
    class Box
    {

        // declare private meber variables
        // this is best practice
        private int length;
        private int width;
        private int height;
        private int volume;


        //create a method to make the member variables public safely; best practice
        public void setDimensions(int length, int width, int height)
        {

            //assign of the class Box to length
            this.length = length;
            this.width = width;
            this.height =height;


        }



        // get length method is used to be able to change the length member variable value individually
        // Note there are other faster wys todo this  go to next solution
        // we are encapsulating the length member variable to restrict acces to it
        // you can even mak thos method private to restcit it even more to be acces only by the class "Box" itself or by inherited classes poutside of it

            // this is a setter and getter method property which gives acces only to the meber variable in the method
            // Always CAPITALIZE PROPERTY NAMES
        public int Length()
        {
            // add conditional stament
            if (length <0)
            {
                // throw and error
                throw new Exception("Length should be higher than 0");
            }
            return this.length;

        }

        // this is a setter and getter method which gives acces only to the meber variable in the method
        // Always CAPITALIZE PROPERTY NAMES
        public int Volume()
        {
            return this.length * this.width * this.height;
        }


        public void DisplayInfo()
        {

            Console.WriteLine("Lengt {0} * height {1} * width {3} is equal to volume {3}", length, width, height, volume=length*width*height);
        }
    }
}
