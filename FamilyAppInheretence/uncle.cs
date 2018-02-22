using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyAppInheretence
{
    public class Uncle : IGrandpa
    {
        public void TakeRubbishOut()
        {
            Console.Write("Taking the rubbish out like a boss");
        }


        public void LikesSpecificFood()
            //need empty method call after it 
        {    
        }
        public void RidesABike()
        {
            Console.Write("I am riding a bike");
        }

        public void LikesOneSpecificFruit()
        {

        }

     
    }
}
