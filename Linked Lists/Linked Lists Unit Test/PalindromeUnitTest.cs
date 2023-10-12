using Linked_Lists.Exercises;
using Linked_Lists.Helpers;

namespace Linked_Lists_Unit_Test
{
    public class PalindromeUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 2, 1 },
                true
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 1 },
                false
            };

            yield return new object[]
            {
                new int[] { 1, 2, 2, 1 },
                true
            };

            yield return new object[]
            {
                new int[] { },
                true
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PalindromeWithDoublyLinkedTest(int[] arr, bool expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToEnd(arr[i]);
            }

            bool result = Palindrome.IsPalindromeWithDoublyLinked(linkedList);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PalindromeWithRecursionTest(int[] arr, bool expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToEnd(arr[i]);
            }

            bool result = Palindrome.IsPalindromeWithRecursion(linkedList, linkedList.Head, null);

            Assert.Equal(expected, result);
        }
    }
}
