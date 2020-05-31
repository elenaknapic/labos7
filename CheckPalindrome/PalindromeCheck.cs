using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckPalindrome
{
    public class PalindromeCheck
    {
        public bool Palindrome(string palindromeString)
        {
            string first = palindromeString.Substring(0, palindromeString.Length / 2);
            char[] arr = palindromeString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }

    }
}
