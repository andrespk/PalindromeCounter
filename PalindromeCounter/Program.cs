using System;

namespace WestPoint.PalindromeCounter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            countPalindromesAndNotify();
        }

        private static void countPalindromesAndNotify()
        {
            var counter = new PalindromeCounter();
            var wordList = counter.GenerateRandomWordList(10000, 3, 5);
            var count = counter.Count(wordList);
            Console.WriteLine($"Paindrome(s) found: {count}");
        }
    }
}