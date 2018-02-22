using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyAppInheretence
{
    public class Son : Mum, IGrandpa
    {
        public Son()
        {

        }

        new public void TakeRubbishOut()
        { Console.WriteLine("I am like my uncle"); }
        

        new public void LikesOneSpecificFruit()
        {
            Console.WriteLine("I like lots of fruit");
        }

       

    }
}
