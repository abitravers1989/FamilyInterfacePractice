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
        

       
   

    }
}
