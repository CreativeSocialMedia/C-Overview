using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_Polymorphic_Parameters
{
    class CarIDInfo
    {

        // each class has a reationship ID
        // this sbuclass create an ID instance that can be used in all the classes and derived classes.

        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No Owner";
    }
}
