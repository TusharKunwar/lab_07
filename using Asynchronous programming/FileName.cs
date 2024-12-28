using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_programming
{
    public class AsyncTest
    {
        public async Task methodOne()
        {
            await Task.Delay(10000);
            Console.WriteLine("I am from method1!");
        }
        public void methodTwo()
        {
            Console.WriteLine("I am from method2!");
        }
    }
}
