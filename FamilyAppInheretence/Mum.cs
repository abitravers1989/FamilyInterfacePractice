using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyAppInheretence
{
    public class Mum : IGrandpa
    {
        public void TakeRubbishOut() { }
        public void LikesSpecificFood()
        {
            Console.WriteLine("I only like pears");
        }
        public void RidesABike()
        {
            Console.Write("I am riding a bike");
        }

        public void LikesOneSpecificFruit()
        {
            Console.WriteLine("I like lots of fruit");
        }

       
    }
}
