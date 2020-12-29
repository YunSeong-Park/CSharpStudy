using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct       // T는 int, string 과같은 값 형식이어야함
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T : class       // T는 class 형식이어야함
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }
    class Base { }          // Base class 선언
    class Derived : Base { }    // Base를 상속하는 Base class 선언
    class BaseArray<U> where U : Base   //  U의 타입은 Base class 로 한정
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);    // source를 Array로 복사
        }
    }
    class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T(); // T형식에 인스턴스를 생성
        }
        public static void WriteArray<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);        // T형식의 배열을 순서대로 출력
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            for (int i = 0; i < a.Array.Length; i++)
            {
                a.Array[i] = i; // 행렬에 1,2,3 을 선언
            }

            WriteArray<int>(a.Array);   //1 2 3 

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);    //0*5
            b.Array[1] = new StructArray<double>(10);   //0*10
            b.Array[2] = new StructArray<double>(1005); //0*1005

            WriteArray<double>(b.Array[0].Array);
            WriteArray<double>(b.Array[1].Array);
            WriteArray<double>(b.Array[2].Array);


            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            WriteArray<Base>(c.Array);

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();     // Derived는 Base선언 불가능
            d.Array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

        }
    }
}
