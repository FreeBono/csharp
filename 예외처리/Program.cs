using System;

namespace 예외처리
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Next Step");
        }

        static void Run()
        {
            try
            {
                int[] a = new int[10];
                
                for (int i =0; i <= 10; i++)
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }

                var fs = File.Open("my.config", FileMode.Open);
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            catch (FileNotFoundException ex)
            {

            }
            catch (Exception ex)
            {
                Log(ex);
                throw;
                throw ex;
                throw new ApplicationException(ex.Message, ex);
            }

        }
        static void Log(Exception ex)
        {
            //File,DB 로깅
        }
        
    }
}
