using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WestPoint.PalindromeCounter
{
    public class PalindromeCounter
    {
        private readonly Word word = new Word();

        public string[] GenerateRandomWordList(int wordCount, int minLength, int maxLength)
        {
            var list = new List<string>();
            var currentWordLength = minLength;
            for (var i = 0; i < wordCount; i++)
            {
                currentWordLength = new Random().Next(minLength, maxLength);
                list.Add(word.GenerateRandom(currentWordLength));
            }
            return list.ToArray();
        }

        private bool isPalindrome(string word)
        {
            var reversedArray = word.ToCharArray();
            Array.Reverse(reversedArray);
            return word.Equals(new string(reversedArray));
        }

        public int Count(string[] wordList)
        => wordList.Count(w => isPalindrome(w));
    }
}