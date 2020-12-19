using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _7.CollectionStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);  // 최상위 데이터는 1
            stack.Push(2);  // 최상위 데이터는 2
            stack.Push(3);  // 최상위 데이터는 3
            stack.Push(4);  // 최상위 데이터는 4
            stack.Push(5);  // 최상위 데이터는 5

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());

           
        }
    }
}
