using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _10.foreachYield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()  //  IEnumerator GetEnumerator()은  foreach에 사용됨
        {
            yield return numbers[0];    // yield return은 현재 메소드를 일시정지시키고 호출자에 결과를 반환하고
            yield return numbers[1];    // 메소드가 다시호출되면, 다시 실행한다
            yield return numbers[2];
            yield break;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);
        }
    }
}
