using Linked_Lists.Helpers;
using Linked_Lists.Exercises;

namespace Linked_Lists_Unit_Test
{
    public class ReturnKthToLastUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                0,
                -1
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                1,
                7
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                4,
                4
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                7,
                1
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                8,
                -1
            };

            yield return new object[]
            {
                new int[] { 6 },
                1,
                6
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ReturnKthToLastWithRunnerTest(int[] arr, int k, int expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToEnd(arr[i]);
            }

            int result = ReturnKthToLast.ReturnKthToLastWithRunner(linkedList, k);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ReturnKthToLastWithCountTest(int[] arr, int k, int expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToEnd(arr[i]);
            }

            int result = ReturnKthToLast.ReturnKthToLastWithCount(linkedList, k);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ReturnKthToLastWithPreviousTest(int[] arr, int k, int expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToEnd(arr[i]);
            }

            int result = ReturnKthToLast.ReturnKthToLastWithPrevious(linkedList, k);

            Assert.Equal(expected, result);
        }
    }
}
