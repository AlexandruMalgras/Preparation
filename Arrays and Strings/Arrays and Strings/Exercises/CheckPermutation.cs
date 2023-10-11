using Arrays_and_Strings.Helpers;

namespace Arrays_and_Strings.Exercises
{
    /*
     * Given two strings, write a method to decide if one is a permutation of the other.
     */

    public static class CheckPermutation
    {
        /*
         * One way to check for permutability is to sort both strings and check whether they are the same.
         */
        public static bool CheckPermutationWithSorting(string first, string second)
        {
            // Check if both strings have the same length.
            if (first.Length != second.Length) return false;

            char[] firstToArray = first.ToCharArray();
            char[] secondToArray = second.ToCharArray();

            // Sort the strings
            QuickSort.QuickSortCharacters(firstToArray, 0, firstToArray.Length - 1);
            QuickSort.QuickSortCharacters(secondToArray, 0, secondToArray.Length - 1);

            // Compare if the strings are the same
            return new string(firstToArray) == new string(secondToArray);
        }

        /*
         * Another way to solve this would be to use the dictionary (hash table) approach.
         */
        public static bool CheckPermutationWithDictionary(string first, string second)
        {
            // Check if both strings have the same length.
            if (first.Length != second.Length) return false;

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < first.Length; i++)
            {
                // Check if the key exists and increment it, otherwise add the key.
                if (dictionary.TryGetValue(first[i], out int value))
                {
                    value++;
                }
                else
                {
                    dictionary.Add(first[i], 1);
                }
            }

            for (int i = 0; i < second.Length; i++)
            {
                // Check if the key exist and decrement it.
                if (dictionary.TryGetValue(second[i], out int value))
                {
                    value--;
                }
                else
                {
                    return false;
                }

                // Check if the second string contains more of the same character than the first string.
                if (dictionary[second[i]] < 0) return false;
            }

            return true;
        }
    }
}
