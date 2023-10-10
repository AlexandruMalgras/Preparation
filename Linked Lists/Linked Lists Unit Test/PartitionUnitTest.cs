using Linked_Lists.Exercises;
using Linked_Lists.Helpers;
using System.Text;

namespace Linked_Lists_Unit_Test
{
    public class PartitionUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 5, 1, 4, 3, 2, 6 },
                4,
                "132546"
            };

            yield return new object[]
            {
                new int[] { 5, 1, 4, 3, 2, 6 },
                7,
                "514326"
            };

            yield return new object[]
            {
                new int[] { 5, 1, 4, 3, 2, 6 },
                0,
                "514326"
            };

            yield return new object[]
            {
                new int[] { },
                0,
                ""
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PartitionWithListsTest(int[] arr, int comparer, string expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.AppendToEnd(arr[i]);
            }

            Partition.PartitionWithLists(linkedList, comparer);

            MyNode<int> node = linkedList.Head;

            StringBuilder result = new StringBuilder();

            while (node != null)
            {
                result.Append(node.Value.ToString());

                node = node.Next;
            }

            Assert.Equal(expected, result.ToString());
        }
    }
}
