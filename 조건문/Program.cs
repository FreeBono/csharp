using System;

namespace 조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 95;
            if (score>= 90)
            {
                if (score == 100)
                {
                    Console.WriteLine("만점");
                }
                Console.WriteLine("수");
            }
            
            else if (score >= 80) {
                Console.WriteLine("우");
            }
            else if (score >= 70) {
                Console.WriteLine("미");
            }
            else if (score >= 60) {
                Console.WriteLine("양");
            }
            else
            {
                Console.WriteLine("가");
            }

            int a = -1;
            // int b;
            // if (a > 0)
            // {
            //     b = a;
            // }
            // else
            // {
            //     b = 0;
            // }
            int b = (a > 0) ? a : 0;



            // switch문
            string option = args[0];
            Console.WriteLine(option);
            switch (option)
            {
                case "a":
                    Console.WriteLine("Phone");
                    break;
                case "b":
                    Console.WriteLine("SMS");
                    break;
                case "c":
                    Console.WriteLine("Kakao");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;
            }
        }
    }
}
