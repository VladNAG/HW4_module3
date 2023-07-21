using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_module3
{
    internal class Starter2
    {
       public static void Start2()
        {
            Console.WriteLine("Hello, Phoneboke, HW paet 2!");
            var myPonebook = new PhoneBook();
            myPonebook.MySelect();
            myPonebook.MyWere();
            myPonebook.MyFirstOrDefault();
            myPonebook.MyAny();
            myPonebook.MySkipTeke();
            myPonebook.MyDistinct();
        }
    }
}
