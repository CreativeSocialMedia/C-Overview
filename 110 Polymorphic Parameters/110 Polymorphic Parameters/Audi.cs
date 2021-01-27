using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_Polymorphic_Parameters
{
    class Audi:Car
    {
        private int model;
        private string brand = "Audi";

        public int Model { get; set; }

        // this constructor uses the base constructor from base class Car 
        public Audi(int model, string color, int hp) : base(hp, color)
        {

            this.Model = model;

            // when you use ":base(hp, color)" dont need these
            // this.Color = color;
            // this.HP = hp;

        }


        public new void ShowDetails()
        {

            Console.WriteLine("Brand: " + brand + "HP: " + HP + "Color: " + Color);

        }

        public override void CarRepaired()
        {

            Console.WriteLine("The Audi {0} has been repaired!", Model);
        }
    }
}
