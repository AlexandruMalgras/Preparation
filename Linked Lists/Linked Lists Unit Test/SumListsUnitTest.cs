using Linked_Lists.Exercises;
using Linked_Lists.Helpers;
using System.Text;

namespace Linked_Lists_Unit_Test
{
    public class SumListsUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 7, 1, 6 },
                new int[] { 5, 9, 2 },
                "912"
            };

            yield return new object[]
            {
                new int[] { 0, 0, 1 },
                new int[] { 2 },
                "102"
            };

            yield return new object[]
            {
                new int[] { 9, 9, 9 },
                new int[] { 2 },
                "1001"
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void SumListsReverseTest(int[] firstNumber, int[] secondNumber, string expected)
        {
            MyLinkedList<int> first = new MyLinkedList<int>();
            MyLinkedList<int> second = new MyLinkedList<int>();

            for (int i = 0; i < firstNumber.Length; i++)
            {
                first.AppendToEnd(firstNumber[i]);
            }

            for (int i = 0; i < secondNumber.Length; i++)
            {
                second.AppendToEnd(secondNumber[i]);
            }

            MyLinkedList<int> temporary = SumLists.SumListsReverse(first, second);

            StringBuilder result = new StringBuilder();

            MyNode<int> node = temporary.Head;

            while (node != null)
            {
                result.Append(node.Value);
                node = node.Next;
            }

            Assert.Equal(result.ToString(), expected);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void SumListsForwardTest(int[] firstNumber, int[] secondNumber, string expected)
        {
            MyLinkedList<int> first = new MyLinkedList<int>();
            MyLinkedList<int> second = new MyLinkedList<int>();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                first.AppendToEnd(firstNumber[i]);
            }

            for (int i = secondNumber.Length - 1; i >= 0; i--)
            {
                second.AppendToEnd(secondNumber[i]);
            }

            MyLinkedList<int> temporary = SumLists.SumListsForward(first, second);

            StringBuilder result = new StringBuilder();

            MyNode<int> node = temporary.Head;

            while (node != null)
            {
                result.Append(node.Value);
                node = node.Next;
            }

            Assert.Equal(result.ToString(), expected);
        }
    }
}
