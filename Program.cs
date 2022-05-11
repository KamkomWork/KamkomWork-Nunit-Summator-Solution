using System;

namespace Summator
{

    public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });


            Console.WriteLine("Enter input");
            string input = Console.ReadLine();
            int expectedValue = Int32.Parse(input);

            if (result == expectedValue)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");

            }


            long average = Summator.Average(new int[] { 5, 10, 15, });

            if (average == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");

            }


        }
           






    }


   





}