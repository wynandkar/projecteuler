using System;
using System.Collections.Generic;

namespace peorjectEuler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            var newElement = 0;
            var limit = 4000000;
            List<int> list = new List<int> { 1, 2 };
            while(newElement < 4000000)
            {
                newElement = list[list.Count-1] + list[list.Count-2];
                Console.WriteLine(newElement);
                if (newElement < limit)
                    list.Add(newElement);
            }

            foreach (var number in list)
            {
                if (number % 2 == 0)
                    total += number;
            }
            Console.WriteLine("Total: " + total);
            Console.ReadLine();
        }
    }
}
