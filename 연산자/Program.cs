using System;

namespace 연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            // 산술 연산자 + - * / %
            int c = 12;
            double f = (c * 9.0 /5.0) + 32;

            int i = 100 % 3;

            // 할당 연산자
            int a = 100;
            a += 50;

            // 증감 연산자
            int x = 0;
            x++;
            ++x;
            x--;
            --x;

            x = 0;
            int y = x++;
            x = 0;
            int z = ++x;

            // 비교 연산자 >=, <, <=, --
            int index = 100;
            if (index >= 100) {}

            // 논리 연산자
            if ( index > 1 && index < 1000)
            {
                index++;
            }

            x = 0;
            y = 1
            if (++x >0 || ++ y >1)
            {
                //...
            }
            Console.WriteLine(x+y); // => 2

            // 비트 연산자 & | ^ (XOR)
            x = 0x07; // 00000111 (7)
            y = 0x0D; // 00001110 (14)
            // x = Convert.ToInt32("00000111",2);
            
            int j = x & y; // 00000110
            j = x | y; // 00001111
            j = x ^ y; // 00001001

            // shift 연산자 << >>
            j = j << 2; // 00100100
            j = 4 << 1; // 0100 => 1000
            j = 8 >> 1; // 4

            // 조건 연산자 ?, ??
            int val;
            if (x > y)
            {
                val = x;
            }
            else
            {
                val = y;
            }
            val = ( x > y) ? x : y;
            string s = null;
            string ss = s ?? "***"

        }
    }
}
