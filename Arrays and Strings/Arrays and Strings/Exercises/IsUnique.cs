using Arrays_and_Strings.Helpers;
using System.Collections.Immutable;

namespace Arrays_and_Strings.Exercises
{
    /*
     * Implement an algorithm to determine if a string has all unique characters.
     * What if you cannot use additional data structures?
     */

    public static class IsUnique
    {
        /*
         * One way to brute force the solution would be to check for each character in the string if any other character
         * ahead of it is not the same.
         */
        public static bool IsUniqueBruteForce(string input)
        {
            // Check if the string has a length greater than the possible number of unique chars in the alphabet
            if (input.Length > 128) return false;

            // Check for each character in the string if there is a duplicate ahead of it.
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /*
         * One way to determine if a string has all unique characters would be to split the algorithm in two tasks.
         * First task sorts the string, and the second task checks if adjacent characters are the same.
         * The tradeoff is that in C# we must create an array of characters to replace the input string.
         * This results in adding another data structure, even though a string is an array of chars.
         * Direct changes to the characters of a string are not allowed in C# and must be done through an array of characters.
         * If the parameter of the algorithm would be char[] instead of string creating another data structure would not be necessary.
         */
        public static bool IsUniqueWithSorting(string input)
        {
            // Check if the string has a length greater than the possible number of unique chars in the alphabet
            if (input.Length > 128) return false;

            char[] characters = input.ToCharArray();

            // Sort the string
            QuickSort.QuickSortCharacters(characters, 0, characters.Length - 1);

            // Check adjacent characters
            for (int i = 0; i < characters.Length - 1; i++)
            {
                if (characters[i] == characters[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        /*
         * Another way to determine if a string has all unique characters is to implement a switch algorithm.
         * The downside is that it requires another data structure, which increases the space complexity.
         */

        public static bool IsUniqueSwitchFlip(string input)
        {
            // Check if the string has a length greater than the possible number of unique chars in the alphabet
            if (input.Length > 128) return false;

            bool[] switches = new bool[128];

            for (int i = 0; i < input.Length; i++)
            {
                // Check if the character already exists.
                if (switches[input[i]])
                {
                    return false;
                }

                switches[input[i]] = true;
            }

            return true;
        }

        /*
         * Another way that uses an extra data structure is to use sets and compare the length of the data structures.
         */

        public static bool IsUniqueWithSets(string input)
        {
            // Check if the string has a length greater than the possible number of unique chars in the alphabet
            if (input.Length > 128) return false;

            return input.ToHashSet<char>().Count == input.Length;
        }
    }
}
