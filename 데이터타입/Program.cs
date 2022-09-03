using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            short sh = 100;
            int i = 100;
            long l = 10000L;
            
            ushort us = 111;
            uint ui = 110U;
            ulong ul = 1000UL;


            float f = 3.14f; // 32비트
            double d = 3.141592d; //64비트 , d생략가능
            decimal dd = 3.14M; // 128비트
            string s = "hello";
            char ch = '한'; // 16비트 유니코드 값
            byte by = 0x46; // 8비트
            object o = "aaa"; // 모든 데이터를 포함

        }
    }
}
