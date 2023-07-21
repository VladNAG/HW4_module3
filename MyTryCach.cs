using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_module3
{
    public class MyTryCach
    {
        public MyTryCach()
        {
            Event = GetSum;
            Event += GetSum;
        }

        public delegate void EventHandler(int x, int y);
        public delegate void DisplaySum(int x, int y);
        public event EventHandler Event;
        public DisplaySum DispSum => SumEvent;
        public int Sum { get; private set; }
        public void SumEvent(int x, int y)
        {
            Event(x, y);
            Console.WriteLine(Sum);
        }

        public void Try(DisplaySum displaySum, int x, int y)
        {
            try
            {
                displaySum(x, y);
            }
            catch (Exception)
            {
                Console.WriteLine("Ex EX EX");
            }
        }

        private void GetSum(int x, int y)
        {
            Sum += x + y;
        }
    }
}
