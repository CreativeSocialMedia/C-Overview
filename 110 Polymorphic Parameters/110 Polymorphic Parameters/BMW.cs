using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_Polymorphic_Parameters
{
    class BMW:Car
    
    {
        private int model;
        private string brand = "BMW";

        public int Model { get; set; }

        // this constructor uses the base constructor from base class Car 
        public BMW(int model, string color, int hp):base(hp, color)
        {

            this.Model = model;

            // when you use ":base(hp, color)" dont need these
            // this.Color = color;
            // this.HP = hp;
       
        }

        // "new" says this has priority over the one in the base class
        public new void ShowDetails()
        {

            Console.WriteLine("Brand: " + brand +  "HP: " + HP + "Color: " + Color);

        }

        // use override to override the method from the base class cars
        public override void CarRepaired()
        {

            Console.WriteLine("The BMW {0} has been repaired!", Model);
        }
    }
}
