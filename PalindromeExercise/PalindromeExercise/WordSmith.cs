using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            if (str == null || str.Length == 0)
            { return false; }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[str.Length-1-i])
                { return true; }
            }
            return false;
        }

    }
}
