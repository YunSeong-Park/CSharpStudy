using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DictiornaryT
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();    // key는 string value는 int

            dic["하나"] = 1;
            dic["둘"] = 2;
            dic["셋"] = 3;
            dic["넷"] = 4;
            dic["다섯"] = 5;

            Console.WriteLine(dic["하나"]);  // 1
            Console.WriteLine(dic["둘"]);    // 2
            Console.WriteLine(dic["셋"]);    // 3
            Console.WriteLine(dic["넷"]);    // 4
            Console.WriteLine(dic["다섯"]);  // 5
        }
    }
}
