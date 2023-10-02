using Arrays_and_Strings.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Strings.Exercises
{
    /*
     * Given a string, write a function to check if it is a permutation of a palindrome.
     * A palindrome is a word or phrase that is the same forwards and backwards.
     * A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
     * You can ignore casing and non-letter characters.
     */
    public class PalindromePermutation
    {
        /*
         * One way to approach this problem is to create a hash table and keep track of the characters and how often they occur.
         * To have a palindrome only one occurance of a character can be odd.
         */
        public static bool PalindromePermutationWithDictionary(string input)
        {
            // Ignore casing
            input = input.ToLower();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            // Track the characters in the string.
            foreach (char c in input)
            {
                // Ignore spaces as they do not matter.
                if (c == ' ') continue;

                if (dictionary.TryGetValue(c, out int value))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }

            // Check how many odd characters exist.
            int oddCount = 0;

            foreach (int i in dictionary.Values)
            {
                if (i % 2 != 0) oddCount++;
            }

            if (oddCount > 1) return false;

            return true;
        }


        /*
         * Another way to solve this is to sort the string and then check for pairs.
         * We can only have 1 non pair.
         */
        public static bool PalindromePermutationWithSorting(string input)
        {
            // Ignore casing
            input = input.ToLower();

            char[] characters = input.ToCharArray();

            QuickSort.QuickSortCharacters(characters, 0, characters.Length - 1);

            int indexToStart = 0;

            // Skip the empty spaces.
            foreach (char c in characters)
            {
                if (c == ' ')
                {
                    indexToStart++;
                }
                else
                {
                    break;
                }    
            }

            int countNonPairs = 0;
            int i = indexToStart;

            for (; i < characters.Length - 1; i++)
            {
                if (countNonPairs > 1) return false;

                if (characters[i] == characters[i + 1])
                {
                    i++;
                }
                else
                {
                    countNonPairs++;
                }
            }

            /* There is a case when we could end at the last index of the array and we do not check
             * because of the conditional statement. Instead of doing more checks inside the loop
             * we can actually check outside if i reached characters.Length - 1 and there is no pair at the end.
             */

            if (i == characters.Length - 1 && characters[i] != characters[i - 1]) countNonPairs++;
            if (countNonPairs > 1) return false;

            return true;
        }
    }
}
