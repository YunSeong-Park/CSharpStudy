using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MyException
{
    class InvalidArgumentException : Exception
    {

        
        public InvalidArgumentException(string message) : base(message) // System.Exception의 생성자에 message를 인풋
        {
        }

        public object Argument
        {
            get;
            set;
        }
        public string Range
        {
            get;
            set;
        }
    }
    class Program
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)  // 4가지 인풋값을 합쳐주는 함ㅁ수
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (uint arg in args)  //  범위(255)에 벗어나는 인풋값이 있는 지 검사하고 벗어난 값이 있다면 예외 처리함.
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    { 
                    Argument = arg,
                    Range = "0~255"
                    };
            }

            return (alpha << 24 & 0xff000000) |
                   (red << 16 & 0x00ff0000) |
                   (green << 8 & 0x0000ff00) |
                   (blue & 0x000000ff);

        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
                Console.WriteLine("0x{0:X}", MergeARGB(1, 65, 192, 128));
                Console.WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));
            }
            catch(InvalidArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument:{e.Argument}, Range:{e.Range}");
            }
        }
    }
}
