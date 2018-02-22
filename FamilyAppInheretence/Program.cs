using System;

namespace FamilyAppInheretence
{
    class Program
    {
        static void Main(string[] args)
        {
           

            IGrandpa mySon = new Son();
            mySon.TakeRubbishOut();
            mySon.LikesSpecificFood();
            mySon.RidesABike();
            Console.ReadLine();
        }
    }
}




//IGrandpa myMum = new Mum();
//myMum.TakeRubbishOut();
           // myMum.LikesOneSpecificFruit();

           // IGrandpa myUncle = new Uncle();
//myUncle.TakeRubbishOut();
