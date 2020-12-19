using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace _7.CollectionsHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";   // key = "하나" value = "one"
            ht["둘"] = "two";     // key = "둘" value = "two"
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            // 키값을 받아서 벨류 값을 반환함
            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"]);


        }
    }
}
