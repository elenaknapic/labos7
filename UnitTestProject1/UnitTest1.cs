using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CheckPalindrome;


namespace CheckPalindrome.Test

{
    [TestFixture]
    public class UnitTest1
    {
        PalindromeCheck palindromeCheck = new PalindromeCheck();

        //Provjera kad je palindrom
        [TestCase("ana")]
        [TestCase("madam")]
        [TestCase("Sir ima miris")]
        [TestCase("sirimamiris")]
        [TestCase("ANA")]

        public void TestMethod1(string input)
        {
            bool expected = true;
            bool actual = palindromeCheck.Palindrome(input);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);

        }


        //Provjera kada nije palindrom
        [TestCase("Ovo nije palindrom")]
        [TestCase("Sto je palindrom")]
        public void TestMethod2(string input)
        {
            bool expected = false;
            bool actual = palindromeCheck.Palindrome(input);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }



        //Provjera kad je empty
        [TestCase(" ")]
        [TestCase()]
        public void TestMethod3(string input)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() => palindromeCheck.Palindrome(input));
        }


    }
}
