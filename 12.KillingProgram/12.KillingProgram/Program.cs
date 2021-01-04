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
            try     //  해당 블록에서 에러가 나오면 catch로 이동
            { 
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);  //  i가 배열의 크기 -1을 넘어서면서 예외를 일으키고 종료된다. 
                }
            }
            catch( IndexOutOfRangeException e)  // IndexOutOfRangeException 발생시 해당 블록실행
            {
                Console.WriteLine($"예외가 발생했습니다. : {e.Message}");
            }
            // 종료 후 순차 실행

            Console.WriteLine("종료");    // try catch 문으로 실행 가능
            
        }
    }
}
