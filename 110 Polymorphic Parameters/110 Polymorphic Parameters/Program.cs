using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _110_Polymorphic_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {


            // this is where polymorphism comes in to play
            // base class is Car
            // now you can use subclass as a listed item
            var cars = new List<Car>
            {

                new Audi(200, "blue", 40),
                new BMW(200, "red", 30)
            };

            // for each subclass listed above do this
            foreach (var car in cars)
            {
                // this derives the method from the subclasses BMW and Audi because of Car set to virtual and the subclass set to override
                car.CarRepaired();
              
            }

            // this prints because const was set to "New" on sub classes Audi and BMW
            // "new" force the const labeled new to execute instead of what is in Base class
            Car bmwz3 = new BMW(200, "black", 300);
            Car audiA3 = new Audi(300, "Green", 400);
            bmwz3.ShowDetails();
            audiA3.ShowDetails();


            // set and get relationship info here
            bmwz3.SetCarIDInfo(123, "Jedi");
            bmwz3.GetCarIDInfo();



            // this calls back the const from the BMW base class
            BMW bmwM5 = new BMW(330, "White", 600);
            bmwM5.ShowDetails();

            // this methos calls back the const from the base class but uses the data from the bmwM5 member variable just created here line 40
            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            Console.ReadKey();
        }

       
    }
}
