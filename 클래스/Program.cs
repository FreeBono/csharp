using System;

namespace 클래스
{
    class Program
    {
        static void Main(string[] args)
        {
            Brick br = new Brick();
            Brick br2 = new Brick(50,100,20,Color.Gray);

            int w = br2.width;
            br2.Width = -1;
            Color c = br2.Color;

            br2.ProcessStarted += Br2_ProcessStarted;
            br2.MakeBrick();
        }

        private static void Br2_ProcessStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Start");
        }
    }
}
