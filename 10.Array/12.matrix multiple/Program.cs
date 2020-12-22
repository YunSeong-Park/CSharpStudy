using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _12.matrix_multiply
{
    class matrix_multiply
    {
        // 2*2 행렬만 계산함
        public int[,] Result = new int[2, 2];
        

        public void multiple(int[,] a, int[,] b, out int[,] Result )    // ref, out이 붙은 인풋은 데이터가 수정됨
        {
            int[,] A = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i,j] = a[i, 0] * b[0, j] + a[i,1]*b[1,j]; //  행렬계산
                }
            }
            Result = A; // 결과값에 계산값할당
        }

        public void matrixPrint(int[,] a)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{a[i, j]} ");   //  행렬 프린트해주는 함수
                }
                Console.WriteLine();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            matrix_multiply multiple = new matrix_multiply();

            // 각 행렬을 정의함
            int[,] A = new int[2, 2] { { 3, 2 },{ 1, 4 } };
            int[,] B = new int[2, 2] { { 9, 2 }, { 1, 7 } };

            // 행렬곱을 실행
            int a = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            int b = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            int c = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            int d = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];

            // 행렬을 구성
            int[,] C = new int[2, 2] { { a, b }, { c, d } };

            
            multiple.multiple(A, B, out multiple.Result);   //  메소드로 행렬곱실행

            multiple.matrixPrint(multiple.Result); 
            multiple.matrixPrint(C);
            // 메소드 행렬곱과 비교
        }
    }
}
