using Trees_and_Graphs.Exercises;
using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs_Unit_Test
{
    public class ListOfDepthsUnitTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                4
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3 , 4, 5, 6, 7},
                3
            };

            yield return new object[]
            {
                new int[] { 1, 2 },
                2
            };

            yield return new object[]
            {
                new int[] {  },
                0
            };

            yield return new object[]
            {
                new int[] { 1 },
                1
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ListOfDepthsWithBFSTest(int[] values, int count)
        {
            Tree<int> tree = new Tree<int>();

            MinimalTree.CreateBinarySearchTree(tree, values);

            List<LinkedList<TreeNode<int>>> linkedLists = ListOfDepths.ListOfDepthsWithBFS(tree);

            int countLinkedLists;

            if (linkedLists != null)
            {
                countLinkedLists = linkedLists.Count;
            }
            else
            {
                countLinkedLists = 0;
            }

            Assert.Equal(count, countLinkedLists);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ListOfDepthsWithDFSTest(int[] values, int count)
        {
            Tree<int> tree = new Tree<int>();

            MinimalTree.CreateBinarySearchTree(tree, values);

            List<LinkedList<TreeNode<int>>> linkedLists = ListOfDepths.ListOfDepthsWithDFS(tree);

            int countLinkedLists;

            if (linkedLists != null)
            {
                countLinkedLists = linkedLists.Count;
            }
            else
            {
                countLinkedLists = 0;
            }

            Assert.Equal(count, countLinkedLists);
        }
    }
}
