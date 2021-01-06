using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StackTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a); 
                // 0으로 나눔
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);    
                // StackTrace는 해당 에러가 어디서 발생했는지 알수 있게 해준다
            }
        }
    }
}
