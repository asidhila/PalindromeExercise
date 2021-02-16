using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrone(string word)
        {
            // reverse the word   //racecar Length-->7 -->6
            var reversed = "";

          for(int i= word.Length - 1; i >= 0; i++)
            {
                reversed += word[i];
            }

          // compare the original with the reversed
          if(reversed.ToLower() == word.ToLower())
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
