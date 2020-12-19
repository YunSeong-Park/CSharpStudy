using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace _7.Collections_Initiate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };  // arr 초기화

            ArrayList list = new ArrayList(arr);    // arr를 이용한 초기화
            foreach (object obj in list)
                WriteLine($"ArrayList : {obj}");    // 123 456 789
            WriteLine();

            Stack stack = new Stack(arr);   // arr를 이용한 초기화
            foreach (object obj in stack)
                WriteLine($"Stack : {obj}");    // 789 456 123 stack은 새로들어오는 인풋 값을 맨 앞에 할당하기 때문에 반대
            WriteLine();

            Queue queue = new Queue(arr);
            foreach (object obj in queue)       // 123 456 789
                WriteLine($"Queue : {obj}");
            WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33 };   
            foreach (object obj in list2)
                WriteLine($"ArrayList2 : {obj}");

            Hashtable ht = new Hashtable()  // HashTable 초기화 첫번째 방법
            {
                {"하나",1 },
                {"둘", 2 },
                {"셋", 3 },
                {"넷", 4 },
                {"다섯", 5 }
            };

            Hashtable ht2 = new Hashtable() // HashTable 초기화 두번째 방법
            {
                ["하나"] = 1,
                ["둘"] = 2,
                ["셋"] = 3,
                ["넷"] = 4,
                ["다섯"] = 5
            };
        }
    }
}
