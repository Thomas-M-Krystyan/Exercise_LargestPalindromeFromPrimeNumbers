using LargestPrimeNumbersProduct.Controllers;
using LargestPrimeNumbersProduct.Models;
using System;

namespace LargestPrimeNumbersProduct
{
    public static class Program
    {
        #region Fields
        private static long minNumber = 10000;
        private static long maxNumber = 99999;
        #endregion

        private static void Main(string[] args)
        {
            // According to client requirements, maximum length of processing numbers is 5-digit
            ApplicationController application = new ApplicationController(minNumber, maxNumber);

            Console.WriteLine("Processing...\n");
            DisplayData(application.GetLargestPrimePalindrome());
        }

        private static void DisplayData(Data result)
        {
            Console.WriteLine($"Palindrome result: {result.StoredResult}\n" +
                              $"1st prime multiplier: {result.FirstMultiplier}\n" +
                              $"2nd prime multiplier: {result.SecondMultiplier}");

            Console.WriteLine("\nEnd of processing");
            Console.ReadKey();
        }
    }
}
