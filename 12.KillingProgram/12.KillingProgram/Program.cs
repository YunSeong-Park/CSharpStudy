using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.KillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);  //  i가 배열의 크기 -1을 넘어서면서 예외를 일으키고 종료된다. 
            }
            Console.WriteLine("종료");    // 16행에서 예외를 일으키고 종료됐기 때문에 실행 되지 않는다.
        }
    }
}
