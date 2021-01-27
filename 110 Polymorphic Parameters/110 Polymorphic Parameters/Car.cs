using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_Polymorphic_Parameters
{
    class Car
    {

       private int hp;
       private string color;

        public int HP { get; set; }
        public string Color { get; set; }


        // has a relationship
        protected CarIDInfo carIDinfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDinfo.IDNum = idNum;
            carIDinfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("car ID: {0} and Owner {1}", carIDinfo.IDNum, carIDinfo.Owner);
        }
        // relationship end


        public Car(int hp, string color) {

            this.HP = hp;
            this.Color = color;
        }


        public void ShowDetails()
        {

            Console.WriteLine("HP: {0} and Color: {1}.", HP, Color);

        }

        // make this void virtual to allow it be orriden by other classses.
        public virtual void CarRepaired() {

            Console.WriteLine("The Jedi Vehicle has been repaired!");
        }

      

    }
}
