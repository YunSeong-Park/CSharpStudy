using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ListT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();   //  int 형식의 list를 생성

            for (int i = 0; i < 5; i++) 
                list.Add(i);        // 0 1 2 3 4

            foreach (int item in list)
                Console.Write($"{item} ");  // 출력
            Console.WriteLine();

            list.RemoveAt(2);   // 0 1 3 4

            foreach (int item in list)
                Console.Write($"{item} ");  // 출력
            Console.WriteLine();

            list.Insert(2, 2);  // 0 1 2 3 4

            foreach (int item in list)
                Console.Write($"{item} ");  // 출력
            Console.WriteLine();

        }
    }
}
