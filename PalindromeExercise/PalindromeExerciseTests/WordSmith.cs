using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeExerciseTests
{
    public class WordSmith
    {
        private IEnumerable<char> reverseWord;

        public bool IsAPalindrome(string word)
        {

            // reverse the word   //racecar Length-->7 -->6
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i++)
            {
                reversed += word[i];
            }

            // compare the original with the reversed
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }

}