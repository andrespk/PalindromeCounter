using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WestPoint.PalindromeCounter
{
    public class PalindromeCounter
    {
        private readonly Word word = new Word();

        public string[] GenerateRandomWordList(int wordCount, int wordLength, int wordSecondLengh)
        {
            var list = new List<string>();
            var currentWordLength = wordLength;
            for (var i = 0; i < wordCount; i++)
            {
                list.Add(word.GenerateRandom(currentWordLength));
                currentWordLength = currentWordLength == wordLength ? wordSecondLengh : wordLength;
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