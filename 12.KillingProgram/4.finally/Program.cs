using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.@finally
{
    class Program
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;  // 나눈 값을 반환함.
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;    // 에러가 발생하더라도 finally 블록을 우선 실행함.
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요. :");
                String temp = Console.ReadLine();
                int diviend = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요. :");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    diviend, divisor, Divide(diviend, divisor));
            }
            catch(FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
