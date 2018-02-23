using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyAppInheretence

    // keep uncle class have it impliment uncle interface then call this on son 
{
    public class Uncle : IUncle
    {
        public void TakeRubbishOut()
        {
            Console.Write("Taking the rubbish out like a boss");
        }

        public void RidesABike()
        {
            Console.Write("I am riding a bike");
        }
     
    }
}
