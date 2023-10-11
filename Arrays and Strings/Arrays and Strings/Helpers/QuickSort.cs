using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Strings.Helpers
{
    public static class QuickSort
    {
        public static void QuickSortCharacters(char[] input, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex) return;

            int pivot = input[highIndex];

            int leftIndex = lowIndex;
            int rightIndex = highIndex;

            // Start moving from both ends of the array
            while (leftIndex < rightIndex)
            {
                // On the left look for elements higher than the pivot
                while (input[leftIndex] <= pivot && leftIndex < rightIndex)
                {
                    leftIndex++;
                }

                // On the right look for elements lower than the pivot
                while (input[rightIndex] >= pivot && rightIndex > leftIndex)
                {
                    rightIndex--;
                }

                // Swap the higher to the right and lower to the left
                Swap(input, leftIndex, rightIndex);
            }

            // Swap the pivot
            Swap(input, leftIndex, highIndex);

            // Recurse till the array is sorted
            QuickSortCharacters(input, lowIndex, leftIndex - 1);
            QuickSortCharacters(input, leftIndex + 1, highIndex);
        }

        public static void Swap(char[] input, int lowIndex, int highIndex)
        {
            char character = input[highIndex];
            input[highIndex] = input[lowIndex];
            input[lowIndex] = character;
        }
    }
}
