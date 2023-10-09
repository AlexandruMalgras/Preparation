using Linked_Lists.Helpers;
using Linked_Lists.Exercises;

namespace Linked_Lists_Unit_Test
{
    public class DeleteMiddleNodeUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new MyNode<int>[] { new MyNode<int>(1), new MyNode<int>(2), new MyNode<int>(3), new MyNode<int>(4), new MyNode<int>(5) },
                1,
                false
            };

            yield return new object[]
            {
                new MyNode<int>[] { new MyNode<int>(1), new MyNode<int>(2), new MyNode<int>(3), new MyNode<int>(4), new MyNode<int>(5) },
                0,
                true
            };

            yield return new object[]
            {
                new MyNode<int>[] { new MyNode<int>(1), new MyNode<int>(2), new MyNode<int>(3), new MyNode<int>(4), new MyNode<int>(5) },
                4,
                true
            };

            yield return new object[]
            {
                new MyNode<int>[] { new MyNode<int>(1), new MyNode<int>(2), new MyNode<int>(3), new MyNode<int>(4), new MyNode<int>(5) },
                2,
                false
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void DeleteMiddleNodeByCountTest(MyNode<int>[] nodes, int index, bool expected)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            for (int i = 0; i < nodes.Length; i++)
            {
                linkedList.AppendToFront(nodes[i]);
            }

            MyNode<int> node = linkedList.Head;

            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            DeleteMiddleNode.DeleteMiddleNodeByCount(linkedList, node);

            bool result = linkedList.CheckIfNodeExists(node);

            Assert.Equal(expected, result);
        }
    }
}
