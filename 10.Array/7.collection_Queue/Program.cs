using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _7.collection_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();    // Queue를 정의
            que.Enqueue(1); // 1을 삽입
            que.Enqueue(2); // 2을 삽입
            que.Enqueue(3); // 3을 삽입
            que.Enqueue(4); // 4을 삽입
            que.Enqueue(5); // 5을 삽입

            while (que.Count > 0)   // Dequeue는 출력과 동시에 삭제됨으로 모두 출력되었을 때는 Count가 0이됨
                Console.WriteLine(que.Dequeue());   // 1 2 3 4 5 
        }
    }
}
