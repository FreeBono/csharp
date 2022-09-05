using System;

namespace yield문
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = GetAllScores();

            foreach (var score in scores)
            {
                Console.WriteLine(score);
            }

            foreach (var score in GetScores())
            {
                Console.WriteLine(score);
            }
        }

        static IEnumerable<int> GetScores()
        {
            int[] scores = new int[] {10,20,30,40,50};
            int total = 0;
            for(int i =0; i < scores.Length;i++) {
                total += scores[i];
                yield return total;
            }
           
        }

        static int[] GetAllScores()
        {
            int[] scores = new int[] {10,20,30};
            return scores;
        }
    }
}
