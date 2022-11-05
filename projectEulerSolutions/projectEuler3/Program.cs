using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;

            var numberToTest = 600851475143;
            List<long> factorList = new List<long>();

            for (long i = 2; i < numberToTest; i++)
            {
                //Console.WriteLine(i);
                if (numberToTest % i == 0)
                {
                    if (factorList.Count == 0)
                        factorList.Add(i);
                    else
                    {
                        var check = true;
                        foreach (var factor in factorList)
                        {
                            if (i % factor == 0)
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check == true)
                        {
                            factorList.Add(i);
                            numberToTest = numberToTest / i;
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Elapsed time: {elapsedTime}");
            foreach (var factor in factorList)
            {
                Console.WriteLine(factor);
            }
            Console.ReadLine();
        }
    }
}