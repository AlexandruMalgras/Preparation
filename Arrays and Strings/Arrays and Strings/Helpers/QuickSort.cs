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

            while (leftIndex < rightIndex)
            {
                while (input[leftIndex] <= pivot && leftIndex < rightIndex)
                {
                    leftIndex++;
                }

                while (input[rightIndex] >= pivot && rightIndex > leftIndex)
                {
                    rightIndex--;
                }

                Swap(input, leftIndex, rightIndex);
            }

            Swap(input, leftIndex, highIndex);

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
