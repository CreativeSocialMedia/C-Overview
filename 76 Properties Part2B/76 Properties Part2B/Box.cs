using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_Properties_Part2B
{
    class Box
    {
        // if you need to use member variables in get and set methods you have to declare them
        // like this first
        private int length;
        private int width;
        private int height;
        private int volume;


        // create properties via get and set length for accessability from an outsitde class
        // you can implement get and set or either one
        // Always CAPITALIZE PROPERTY NAMES
        public int Width
        {
            get
            {
                return width;
            }
            set
            {

                width = value;

            }

        }

        public int Length
        {
            get
            {
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

        public int Volume
        {

            get
            {

                return volume = setWidth * setHeight * setWidth;
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }


    }
}

