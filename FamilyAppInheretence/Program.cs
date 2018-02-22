using System;

namespace FamilyAppInheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            IGrandpa myMum = new Mum();
            myMum.TakeRubbishOut();
            myMum.LikesOneSpecificFruit();

            IGrandpa myUncle = new Uncle();
            myUncle.TakeRubbishOut();

            IGrandpa mySon = new Son();
            mySon.TakeRubbishOut();
            Console.ReadLine();
        }
    }
}
