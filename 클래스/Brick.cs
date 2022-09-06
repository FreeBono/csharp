using System;

namespace 클래스
{
    class Brick
    {
        // 필드 (데이타)
        private int width;
        private int height;
        private int depth;
        private Color color;

        // 생성자 (Constructor)
        public Brick()
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.red;
        }

        public Brick(int width, int height, int depth, Color color)
        {
          this.width = width;
          this.height = height;
          this.depth = depth;
          this.color = color;
        }

        // 속성(Property)
        public int width
        {
          get { return this.width;}
          set
          {
            if (value > 0 )
            {
              this.width = value
            }
              
          }
        }
        public Color color
        {
          get { return this.color;}
        }

        public int Volume
        {
          get { return width * height  * depth;}
        }

        // 메서드 (Method)
        public void MakeBrick()
        {
          if (ProcessStarted != null) 
          {
            ProcessStarted(this, EventArgs.Empty);
          }
          Step1();
          Step2();
          Step3();
          if (ProcessCompleted != null)
          {
            ProcessComplted(this, EventArgs.Empty);
          }
        }

        private void Step1()
        {
          Console.WriteLine("Step #1");
        }
        private void Step2()
        {
          Console.WriteLine("Step #2");
        }
        private void Step3()
        {
          Console.WriteLine("Step #3");
        }

        public event EventHandler ProcessStarted;
        public event EventHandler ProcessCompleted;
    }
}
