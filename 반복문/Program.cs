using System;

namespace 반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 루프
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // for 루프
            for(int j = 1; j <=10; j++)
            {
                Console.WriteLine(j);
            }

            // foreach 루프
            string[] cities = new string[] {"Seattle","Paris","London"};
            foreach(string city in cities)
            {
                Console.WriteLine(city);
            }

            // do ~ while 루프
            string menu;
            do
            {
                Console.WriteLine("Select City: (S)eattle (P)aris (L)ondon (Q)uit");
                menu = Console.ReadLine();
                Console.WriteLine(menu + "is selected");
            } while (menu != "Q");
        }

        
    }
}
