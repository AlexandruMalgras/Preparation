using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Strings.Exercises
{
    /*
     * Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient
     * space at the end to hold the additional characters, and that you are given the true length of the string.
     */
    public class URLify
    {
        /*
         * One way to solve this problem is to replace the characters from the string to the end by reading the array backwards.
         */
        public static void URLifyBackwards(char[] input)
        {
            // Check if the array is empty
            if (input.Length == 0) return;

            // Index to fill the empty allocated spaces in the string.
            int indexToPlace = input.Length - 1;

            // Start reading characters from the end of the string, keeping track of their new index to be placed at.
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '\0') continue;

                if (input[i] == ' ')
                {
                    input[indexToPlace] = '0';
                    input[indexToPlace - 1] = '2';
                    input[indexToPlace - 2] = '%';

                    indexToPlace -= 3;
                }
                else
                {
                    input[indexToPlace] = input[i];
                    indexToPlace--;
                }
            }
        }
    }
}
