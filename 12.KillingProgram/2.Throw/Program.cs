using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Throw
{
    class Program
    {
        static void DoSomeThing(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");  // 입력받은 숫자를 출력
            else
                throw new Exception("arg가 10보다 큽니다.");  // 숫자가 10이상일 때 예외를 던짐
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomeThing(1);
                DoSomeThing(3);
                DoSomeThing(5);
                DoSomeThing(9);
                DoSomeThing(11);    //  예외 상황으로 catch 블록실행
                DoSomeThing(13);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
