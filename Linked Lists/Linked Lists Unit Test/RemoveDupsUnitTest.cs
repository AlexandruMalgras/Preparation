using Linked_Lists.Helpers;
using Linked_Lists.Exercises;
using System.Runtime.Serialization;

namespace Linked_Lists_Unit_Test
{
    public class RemoveDupsUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] {1 , 1},
                1
            };

            yield return new object[]
            {
                new int[] { 1 },
                1
            };

            yield return new object[]
            {
                new int[] {},
                0
            };

            yield return new object[]
            {
                new int[] { 0, 1, 2, 1, 3, 1, 4, 1, 5, 1, 6, 1, 1 },
                7
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RemoveDupesWithHashSetTest(int[] arr, int expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToFront(arr[i]);
            }

            RemoveDups.RemoveDupsWithHashSet(linkedList);

            int countNodes = 0;

            MyNode<int> node = linkedList.Head;

            while (node != null)
            {
                countNodes++;
                node = node.Next;
            }

            Assert.Equal(countNodes, expected);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RemoveDupesWithNestedLoopsTest(int[] arr, int expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToFront(arr[i]);
            }

            RemoveDups.RemoveDupsWithNestedLoops(linkedList);

            int countNodes = 0;

            MyNode<int> node = linkedList.Head;

            while (node != null)
            {
                countNodes++;
                node = node.Next;
            }

            Assert.Equal(countNodes, expected);
        }
    }
}