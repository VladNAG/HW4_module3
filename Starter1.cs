using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW4_module3.MyTryCach;

namespace HW4_module3
{
    public static class Starter1
    {
        public static void Start()
        {
            Console.WriteLine("HW part 1");
            var test = new MyTryCach();
            test.Try(test.DispSum, 6, 7);
            Console.WriteLine("Finish");
            Console.WriteLine();
        }
    }
}
