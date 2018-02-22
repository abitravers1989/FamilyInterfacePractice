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
            Console.ReadLine();
        }
    }
}
