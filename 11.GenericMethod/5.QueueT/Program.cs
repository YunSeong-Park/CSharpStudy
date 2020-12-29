using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.QueueT
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();    // int 형식의 Queue 인스턴스 생성
            queue.Enqueue(1);   // 데이터 삽입
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue()); //  queue는 삽입된 순서로 출력됨

            Stack<int> stack = new Stack<int>();    // int 형식의 stack 인스턴스 생성
            stack.Push(1);  //  데이터 삽입
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop()); //  stack은 최근 데이터가 출력됨
        }
    }
}
