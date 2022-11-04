using System;

namespace projectEuler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    answer += i;
                }
            }
            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
        }
    }
}