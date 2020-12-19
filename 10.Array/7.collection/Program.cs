using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   //  Collections 를 사용하기 위한 형식

namespace _7.collection_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();   // ArrayList 생성
            for (int i = 0; i < 5; i++)
                list.Add(i);                    // list에 1~4 삽입

            foreach (object obj in list)        
                Console.Write($"{obj} ");       // 0 1 2 3 4
            Console.WriteLine();

            list.RemoveAt(2);   // 위치 2요소를 삭제

            foreach (object obj in list)
                Console.Write($"{obj} ");       // 0 1 3 4
            Console.WriteLine();

            list.Insert(2, 2);  // 위치 2에 2를 삽입

            foreach (object obj in list)
                Console.Write($"{obj} ");       // 0 1 2 3 4
            Console.WriteLine();

            list.Add("abc"); // 맨뒤에 "abc" 를 삽입
            list.Add("def"); // 맨뒤에 "def" 를 삽입

            for (int i = 0; i < list.Count; i++)
                Console.Write($"{list[i]} ");   // 0 1 2 3 4 abc def
            Console.WriteLine();

        }
    }
}
