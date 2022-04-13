using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Logic;

namespace Logic.Tests
{
    public class LogicTests
    {
        CSharpLogic csharpLogic;

        public LogicTests()
        {
            csharpLogic = new CSharpLogic();
        }

        [Fact]
        public void GetDiscount_MoreThan99Units_Returns15PercentDiscount()
        {
            var unitprice = new decimal(10.1);
            int qty = 101;
            var expected = new decimal(867.09);
            var actual = csharpLogic.GetDiscount(unitprice, qty);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDiscount_50Units_Returns10PercentDiscount()
        {
            var unitprice = new decimal(10);
            int qty = 50;
            var expected = new decimal(450);
            var actual = csharpLogic.GetDiscount(unitprice, qty);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDiscount_49Units_ReturnsActualPrice()
        {
            var unitprice = new decimal(1.11);
            int qty = 49;
            var expected = new decimal(54.39);
            var actual = csharpLogic.GetDiscount(unitprice, qty);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_90_ReturnsA()
        {
            int input = 90;
            char expected = 'A';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_89_ReturnsB()
        {
            int input = 89;
            char expected = 'B';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_80_ReturnsB()
        {
            int input = 80;
            char expected = 'B';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_79_ReturnsC()
        {
            int input = 79;
            char expected = 'C';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_70_ReturnsC()
        {
            int input = 70;
            char expected = 'C';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_69_ReturnsD()
        {
            int input = 69;
            char expected = 'D';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_60_ReturnsD()
        {
            int input = 60;
            char expected = 'D';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGrade_59_ReturnsF()
        {
            int input = 59;
            char expected = 'F';
            var actual = csharpLogic.GetGrade(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveEvenLength_OneThroughTen_ReturnsOnlyOddLengthWords()
        {
            var input = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            var expected = new List<string>() { "one", "two", "three", "six", "seven", "eight", "ten" };
            var actual = csharpLogic.RemoveEvenLength(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveEvenLength_EmptyList_ReturnsEmptyList()
        {
            var input = new List<string>() { };
            var expected = new List<string>() { };
            var actual = csharpLogic.RemoveEvenLength(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerArray_EmptyArray_ReturnsEmptyArray()
        {
            double[] input = { };
            var actual = csharpLogic.PowerArray(input);
            Assert.Empty(actual);
        }

        [Fact]
        public void PowerArray_Doubles_ReturnsSquares()
        {
            double[] input = { -2.2, 0, 1.1, 3 };
            var actual = csharpLogic.PowerArray(input);
            double[] expected = { 4.84, 0, 1.21, 9 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IndexOfMax_PositiveArray_ReturnsMaxIndex()
        {
            int[] input = { 7, 91, 2, 45, 101, 6 };
            int expected = 4;
            var actual = csharpLogic.IndexOfMax(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IndexOfMax_NegativeArray_ReturnsMaxIndex()
        {
            int[] input = { -10, -5, -100 };
            int expected = 1;
            var actual = csharpLogic.IndexOfMax(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IndexOfMax_FirstNumberIsMax_Returns0()
        {
            int[] input = { 0, -25, -20 };
            int expected = 0;
            var actual = csharpLogic.IndexOfMax(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IndexOfMax_EmptyArray_ReturnsNegative1()
        {
            int[] input = { };
            int expected = -1;
            var actual = csharpLogic.IndexOfMax(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsDivisibleBy_MultiplesOf3AndDivisorOf3_ReturnsTrue()
        {
            var array = new List<int>() { 3, 6, 9, 12, 15 };
            int divisor = 3;
            var actual = csharpLogic.IsDivisibleBy(array, divisor);
            Assert.True(actual);
        }


        [Fact]
        public void IsDivisibleBy_NonMultiples_ReturnsFalse()
        {
            var input = new List<int>() { 4, 7, 6, 97, 153 };
            int divisor = 2;
            var actual = csharpLogic.IsDivisibleBy(input, divisor);
            Assert.False(actual);
        }


        [Fact]
        public void IsAbecedarian_biopsy_ReturnsTrue()
        {
            string input = "biopsy";
            var actual = csharpLogic.IsAbecedarian(input);
            Assert.True(actual);
        }

        [Fact]
        public void IsAbecedarian_BeRrY_returnsTrue()
        {
            string input = "BeRrY";
            var actual = csharpLogic.IsAbecedarian(input);
            Assert.True(actual);
        }

        [Fact]
        public void IsAbecedarian_baby_ReturnsFalse()
        {
            string input = "baby";
            var actual = csharpLogic.IsAbecedarian(input);
            Assert.False(actual);
        }

        [Fact]
        public void AreAnagrams_ValidAnagrams_ReturnsTrue()
        {
            string input1 = "statue";
            string input2 = "astute";
            var actual = csharpLogic.AreAnagrams(input1, input2);
            Assert.True(actual);
        }

        [Fact]
        public void AreAnagrams_DifferentLengthStrings_ReturnsFalse()
        {
            string input1 = "state";
            string input2 = "astute";
            var actual = csharpLogic.AreAnagrams(input1, input2);
            Assert.False(actual);
        }

        [Fact]
        public void AreAnagrams_WithDifferentCountsOfLetterOccurences_ReturnsFalse()
        {
            string input1 = "aaab";
            string input2 = "abbb";
            var actual = csharpLogic.AreAnagrams(input1, input2);
            Assert.False(actual);
        }

        [Fact]
        public void AreAnagrams_ValidAnagramsWithCaps_ReturnsTrue()
        {
            string input1 = "Statue";
            string input2 = "Astute";
            var actual = csharpLogic.AreAnagrams(input1, input2);
            Assert.True(actual);
        }

        [Fact]
        public void AreAnagrams_InvalidAnagrams_ReturnsFalse()
        {
            string input1 = "csharp";
            string input2 = "python";
            var actual = csharpLogic.AreAnagrams(input1, input2);
            Assert.False(actual);
        }

        [Fact]
        public void CountUniqueCharacters_5LetterWordWith2Duplicates_Returns3()
        {
            string input = "llama";
            var actual = csharpLogic.CountUniqueCharacters(input);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void CountUniqueCharacters_6LetterWordWithoutDuplicates_Returns6()
        {
            string input = "number";
            var actual = csharpLogic.CountUniqueCharacters(input);
            Assert.Equal(6, actual);
        }


        [Fact]
        public void IsPalindrome_ValidPalindromicWord_ReturnsTrue()
        {
            var input = "madam";
            var actual = csharpLogic.IsPalindrome(input);
            Assert.True(actual);
        }


        [Fact]
        public void IsPalindrome_SingleLetter_ReturnsTrue()
        {
            var input = "a";
            var actual = csharpLogic.IsPalindrome(input);
            Assert.True(actual);
        }


        [Fact]
        public void IsPalindrome_InvalidPalindrome_ReturnsFalse()
        {
            var input = "gamehendge";
            var actual = csharpLogic.IsPalindrome(input);
            Assert.False(actual);
        }

        [Fact]
        public void TestConcordanceForGoodString()
        {
            var input = "engineering";
            var eIndices = new int[3] { 0, 5, 6 };
            var nIndices = new int[3] { 1, 4, 9 };
            var gIndices = new int[2] { 2, 10 };
            var iIndices = new int[2] { 3, 8 };
            var rIndices = new int[1] { 7 };

            var actual = csharpLogic.ConcordanceForString(input);
            Assert.Equal(5, actual.Count);  //Ensure 5 total keys
            Assert.Equal(eIndices, actual["e"]); //Ensure the correct indices in the correct order
            Assert.Equal(nIndices, actual["n"]);
            Assert.Equal(gIndices, actual["g"]);
            Assert.Equal(iIndices, actual["i"]);
            Assert.Single(actual["r"]);
        }
    }
}
