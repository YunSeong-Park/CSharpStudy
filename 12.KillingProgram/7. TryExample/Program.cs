using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.TryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[10];

                for (int i = 0; i < 10; i++)
                    arr[i] = i;

                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);  // arr 범위에 벗어나 오류 발생
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");
            }
        }
    }
}
