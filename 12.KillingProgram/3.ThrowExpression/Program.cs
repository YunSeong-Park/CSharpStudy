using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ThrowExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;  // a를 null로 선언
                int b = a ?? throw new ArgumentNullException(); // a가 null이라면 예외를 실행
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 0;
                int value = array[
                    index >= 0 && index < 3     //조건식
                    ? index : throw new IndexOutOfRangeException()  //조건식이 참이라면 index를 거짓이라면 예외를 실행
                    ];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
