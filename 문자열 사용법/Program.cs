using System;

namespace 문자열_사용법
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열(string)
            string s1 = "c#";
            string s2 = "Programming";

            // 문자(char)
            char c1 = 'A';
            char c2 = 'B';

            char c = s2[0];
            // s2[0] = '1'; (x)

            // 문자열 결합
            string s = s1 + " " + s2;

            // 문자열을 문자배열로
            char[] arr = s.ToCharArray();
            for (inti = 0; i < arr.Length; i ++) 
            {
                Console.WriteLine(arr[i]);
            }

            // 문자배열을 문자열로
            string ss = new string(arr);


            // 부분문자열
            string s4 = s2.Substring(1,4); // rogr

            // 문자열 치환
            string s5 = s2.Replace("Pro","PRO");
            Console.WriteLine(s5);

            // 문자열 삭제
            string s6 = s2.Remove(3);

            // 공백 삭제
            string s7 = "Hello        ".Trim();


            // 문자열(string) immutable type (변경 불가)
            string s1 = "c#"; 

            // 비효율적인 방법, 메모리 에러가 날 수 있음
            // string s = "";
            // for (int i = 0; i < 100000; i++)
            // {
            //     s = s + i.ToString();
            // }

            StringBuilder sb = new StringBuilder(); // mutable type
            for (int i = 0; i< 100000; i++)
            {
                sb.Append(i.ToString());
            }
            string result = sb.ToString();

            // mutable type
            int i = 1;
            i = 2;
        }
    }
}
