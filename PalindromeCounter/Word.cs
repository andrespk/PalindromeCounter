using System;
using System.Collections.Generic;
using System.Text;

namespace WestPoint.PalindromeCounter
{
    public class Word
    {
        public readonly string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        public string GenerateRandom(int length)
        {
            var value = string.Empty;
            for (var i = 0; i < length; i++)
            {
                value += _alphabet[new Random().Next(_alphabet.Length)];
            }
            return value;
        }
    }
}