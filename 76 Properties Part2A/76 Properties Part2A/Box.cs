using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_Properties_Part2A
{
    class Box
    {
        // another way is to declare the member variable as a property instead of a member variable. 
        // we will do that with the width


        // if you want to use member variables here you have to declare them as private
        // see solution part2B
        /* 
         
       private int length;
        private int width;
        private int height;
             */



        // here we declare width as a property member variable 
        // Always CAPITALIZE PROPERTY NAMES
        public int Width { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }

        public int Volume {


            // there is no need to set the volume because it is returning a int value
            get
            {
                return Length * Height * Width;


            }

   
            

        }

        /* // long hand version have to declare member variable first this way expand to see
         public int volume;

        private int length;
        private int height;
        private int volume;

 
        // Always CAPITALIZE PROPERTY NAMES
        public int Length
        {

            get {

                return length;
            }


            set

            {

                length = value;
            }
        }


        public int Height
        {

            get
            {

                return height;
            }


            set

            {

               height = value;
            }
        }

         public int Volume {



            get
            {

                return setVolume;

            }

            set
            {

                this.volume = value;
            }



        }

        public int CalcVolume()
        {

            return  this.setLength * this.setWidth * this.setHeight;
        }
        */







    }


}
