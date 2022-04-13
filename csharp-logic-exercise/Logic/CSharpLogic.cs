using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class CSharpLogic
    {

        /// <summary>
        /// Takes a decimal for the unit price and an int for number of units sold and returns a
        /// discounted sales total based on the quantity sold: 
        /// if greater than 99 units are sold, apply a 15% discount to the total price
        /// if greater than 49 units are sold, apply a 10% discount 10% to the total price; 
        /// if fewer than 50 units are sold, do not apply a discount to the price. 
        /// For example, if the unit price was 1.00 and the quantity sold was 100, the method
        /// should return 85.00 for the total sales amount.
        /// </summary>
        /// <param name="unitPrice">the unit price per item</param>
        /// <param name="unitAmount">the quanity being purchased</param>
        /// <returns>decimal of the discount to be applied</returns>
        public decimal GetDiscount(decimal unitPrice, int unitAmount)
        {
            if (unitAmount > 99)
            {
                unitPrice = unitPrice - (unitPrice * .15M);
            }
            if (unitAmount > 49 && unitAmount <= 98)
            {
                unitPrice = unitPrice - (unitPrice * .10M);
            }

            return Math.Round(unitAmount * unitPrice, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// This method takes an int representing a percentile score and should return the appropriate
        /// letter grade. 
        /// If the score is at least 90, return 'A'
        /// If the score is at least 80, but less than 90, return 'B'
        /// If the score is at least 70, but less than 80, return 'C'
        /// If the score is at least 60, but less than 70, return 'D'
        /// If the score is below 60, return 'F'.
        /// </summary>
        /// <param name="score">Percentile score</param>
        /// <returns>char of the letter grade</returns>
        public char GetGrade(int score)
        {
            if (score >= 90)

                return 'A';

            else if (score >= 80 && score < 90)

                return 'B';

            else if (score >= 70 && score < 80)

                return 'C';

            else if (score >= 60 && score < 70)

                return 'D';

            else if (score < 60)
            { }
            return 'F';

        }

        /// <summary>
        /// This method should take a List of strings, remove all the elements
        /// containing an even number of letters, and return the result. For example, if given a
        /// List of "Cat", "Dog", "Bird", the method should return a List containing only "Cat" and
        // "Dog".
        /// </summary>
        /// <param name="a">Input list of strings</param>
        /// <returns>list of strings</returns>
        public List<string> RemoveEvenLength(List<string> a)
        {
            foreach (var word in a.ToList()) //toList creates a copy of list because C# doesn't like
            {                                //to modify what is being iterated through.
                if (word.Length % 2 == 0)    //if the word length has 0 remainder after being divided by 2 (if it is even),
                {
                    a.Remove(word); //remove that word from the list, thus leaving only the odds.
                }
            }
            return a;
        }

        /// <summary>
        /// This method should take a double array, numbers, and return a new array containing the square of
        /// each element in numbers.
        /// </summary>
        /// <param name="numbers">Input array</param>
        /// <returns>double array</returns>
        public double[] PowerArray(double[] numbers)
        {
            double[] square = new double[numbers.Length]; //creates new double array

            for (int i = 0; i < numbers.Length; i++) //creates variable with value set to 0, increment by one per loop
            {
                var number = (decimal)numbers[i];
                square[i] = (double)(number * number); //calculates the sqaure

            }
            return square;
        }

        /// <summary>
        /// This method should take an int array, numbers, and return the index of the element with the greatest value.
        /// If there the array is empty, return -1
        /// </summary>
        /// <param name="numbers">Input array</param>
        /// <returns>int index of max</returns>
        public int IndexOfMax(int[] numbers)
        {
            int index = -1; //sets index to return -1 if array is empty

            if (numbers != null && numbers.Length > 0) //if numbers aren't null and the length is greater than 0,
            {
                index = Array.IndexOf(numbers, numbers.Max()); //index becomes the index number with maximum value.
            }
            return index;
        }

        /// <summary>
        /// This method should take a List of ints, numbers, and returns true if all elements in the
        /// array are divisible by the given int, divisor.
        /// </summary>
        /// <param name="numbers">Input List<int></param>
        /// <param name="divisor">divisor</param>
        /// <returns>bool of true/false</returns>
        public bool IsDivisibleBy(List<int> numbers, int divisor)
        {
            var AllEven = false; //sets the variable default to return a false value

            foreach (var number in numbers) //for each number in the List,
            {
                if (number % divisor == 0) //if the number is divisible by whichever divisor is indicated,
                {
                    AllEven = true; //variable returns true.
                }
                else
                {
                    AllEven = false; //otherwise, false.
                }
            }
            return AllEven;
        }

        /// <summary>
        /// A word is "abecedarian" if its letters appear in alphabetical order--the word 'biopsy'
        /// for example. This method should take String s and return true if it is abecedarian.
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>bool</returns>
        public bool IsAbecedarian(string s)
        {
            string lowerString = s.ToLower(); //converts string to lower case
            int stringLength = s.Length; //variable for length of string

            char[] charArray = new char[stringLength]; //new array that takes in length of string variable

            for (int i = 0; i < stringLength; i++) //places the string into the array, incrememnt by 1 per loop
            {
                charArray[i] = lowerString[i]; //sets indices of array equal to string characters
            }

            Array.Sort(charArray); //sorts the array alphabetically

            for (int i = 0; i < stringLength; i++)
                if (charArray[i] != lowerString[i]) //checks if object at the index of array is equal to string. If not, then false.

                    return false;

            return true; //otherwise, true.

        }

        /// <summary>
        /// This method should take 2 strings and return true if they are anagrams of each other.
        /// For example, "stop" is an anagram for "pots".
        /// </summary>
        /// <param name="s1">Input string one</param>
        /// <param name="s2">Input string two</param>
        /// <returns>bool</returns>
        public bool AreAnagrams(string s1, string s2)
        {
            var isAnagram = true; //sets default to true

            string string1 = s1.ToLower(); //converts strings to lowercase
            string string2 = s2.ToLower();

            if (string1.Length != string2.Length) //if length of strings are not the same, return false
            {
                return false;
            }
            List<char> list1 = string1.ToList(); //creates copy of list, because C# doesn't like
            List<char> list2 = string2.ToList(); //to modify what is being iterated through.

            for (int i = 0; i < string1.Length; i++) //places string into list1
            {
                if (!list2.Remove(list1[i])) //attempts to remove list1 string from list2
                {                            //if nothing is found to remove, they are not anagrams   
                    return false;
                }
            }
            return isAnagram;
        }

        /// <summary>
        /// This method should take a String and return the number of unique characters. For example, if
        /// the method is given "noon", it should return a value of 2.
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>int count of unique chars</returns>
        public int CountUniqueCharacters(string s)
        {
            var count = s.Distinct().Count(); //creates variable to return distint elements (.Distinct)
                                              //as well as the int or number of those elements (.Count)                  

            return count;
        }

        /// <summary>
        /// This method should take a string and return true if it is a palindrome, i.e. it is spelled the 
        /// same forwards and backwards. For example, the words "racecar" and "madam" are palindromes.
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>bool of true/false</returns>
        public bool IsPalindrome(string s)
        {
            var palindromeWord = true; //sets default to true
            int length = s.Length;

            for (int i = 0; i < length / 2; i++) //declares a variable with value 0 that will increment by 1 per loop.
            {                                    //"length / 2" for dividing string in half to keep from checking same characters twice.
                if (s[i] != s[length - i - 1])   //if characters at beginning and end of string moving inward do not match, not a palindrome.
                {
                    return false;
                }
            }
            return palindromeWord;
        }

        /// <summary>
        /// This method should take a string and return a dictionary which is a map of characters to a list of
        /// their indices in a string (i.e., which characters occur where in a string). For example for the
        /// string "Hello World", the map would look something like: d=[10], o=[4, 7], r=[8], W=[6], H=[0], l=[2, 3, 9], e=[1], ' '=[5].
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>Dictionary<string, List<int>></returns>
        public Dictionary<string, List<int>> ConcordanceForString(string s)
        {
            Dictionary<string, List<int>> newDictionary = new Dictionary<string, List<int>>();

            string lowerString = s.ToLower(); //used in case other words are tested beyond what is listed in the tests page. 
            char[] charArray = lowerString.ToCharArray(); //defines new array to pass strings into.

            for (int i = 0; i < charArray.Length; i++) //declares variable with value 0 that will increment by 1 per loop.
            {
                if (newDictionary.TryGetValue(charArray[i].ToString(), out List<int> myList)) //passes character value into array, then converts to string, then pushes into list.
                {                                                                             //"out" is used so that new list doesn't have to be defined ahead of time.
                    myList.Add(i); //loops through value, adds index to new list.
                }
                else
                {
                    List<int> myNewestList = new List<int>(); //otherwise, creates another new list, and then passes, converts, and pushes.
                    myNewestList.Add(i);
                    newDictionary.Add(charArray[i].ToString(), myNewestList);
                }
            }
            return newDictionary;
        }
    }
}
