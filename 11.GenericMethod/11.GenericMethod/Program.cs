using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GenericMethod
{
    class Program
    {
        static void CopyArray<T>(T[] source, T[] target)    // <T>로 T를 데이터 타입의 변수로 지정함
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };       // int 타입의 길이 5행렬 생성
            int[] target = new int[source.Length];  // source와 같은 길이의 행렬을 초기화

            CopyArray<int>(source, target);         // <int>로 souce, target의 형식을 지정해줌

            foreach (int element in target)
            {
                Console.WriteLine(element);         // target의 요소들을 출력함
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };    // string 타입의 길이 5행렬 생성
            string[] target2 = new string[source2.Length];              // source2와 같은 길이의 행렬을 초기화

            CopyArray<string>(source2, target2);    // <string>으로 souce, target의 형식을 지정해줌

            foreach (string element in target2)
            {
                Console.WriteLine(element);     // target2의 요소들을 출력함
            }
        }
    }
}
