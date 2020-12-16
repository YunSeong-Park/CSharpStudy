using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.systemArray2
{
    class Program
    {
        private static bool CheckPassed(int Score) // 스태틱 함수이기 때문에 객체생성 없이 실행 가능
        {
            if (Score >= 60)
                return true;
            else
                return false;
        }

        private static void Print(int value)
        {
            Console.WriteLine($"{value}");
        }

        static void Main(string[] args)
        {
                //  행렬 정의
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"{score} ");  // 80 74 81 90 34 
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));     // 34 74 80 81 90
             // Array.ForEach<T>( T 형식의 배열, new Action<T>(return이 없는 메소드))
             // 배열요소를 모두 method에 넣어 결과를 받음
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}"); //  Number of dimensions : 1

            Console.WriteLine("Binary Search : 81 is at {0}",
                Array.BinarySearch<int>(scores, 81));   // scores 에서 81의 위치
            Console.WriteLine("Linear Search : 90 is at {0}",
                Array.IndexOf(scores,90));  // scores 에서 90의 위치

            Console.WriteLine("Everyone passed ? : {0}",
                Array.TrueForAll<int>(scores, CheckPassed));    // false
            // 모든 요소가 CheckPassed 에 참이라면 true를 그렇지 않다면 false를 반환함
            int index = Array.FindIndex<int>(scores,
                delegate (int score)
                {
                    if (score < 60)
                        return true;
                    else
                        return false;
                });
            // 조건에 만족하는 첫번째 인덱스를 반환 
            // 60보다 낮은 첫번째 데이터를 반환함

            scores[index] = 61;
            // 60을 넘지 못하는 배열은 61로 수정
            Console.WriteLine("Everyone passed ? : {0}",
                Array.TrueForAll<int>(scores, CheckPassed));    // true 조건 만족

            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}"); // 5

            Array.Resize<int>(ref scores, 10);  // 배열의 길이를 10으로 조절

            Console.WriteLine($"New length of scores : {scores.Length}");   // 10

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);  // 3부터 7개를의 요소를 초기화

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

        }
    }
}
