using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_programming
{
    public class AsyncTest
    {
        public void methodOne()
        {
            Thread.Sleep(10000);
        }
        public void methodTwo()
        {
            Console.WriteLine("I am from method2!");
        }
    }
}
