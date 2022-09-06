using System;

namespace 구조체
{
    class Program
    {
        struct Rect
        {
            public int Left;
            public int Top;
            public int Height;
            public int Width;
            public Rect(int left, int top, int width, int height)
            {
                Left = left;
                Top = top;
                Width = width;
                Height = height;
            }
        }

        static void Main(string[] args)
        {
            Rect r = new Rect(10,10,100,100);
            Draw(r);
        }

        static void Draw(Rect r)
        {
            DrawRectangle(r);
            PrintData(r);
        }

        static void PrintData(Rect r)
        {
            int right = r.Left + r.Width;
            int bottom = r.Top + r.Height;
        }
    }
}
