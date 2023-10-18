using Trees_and_Graphs.Exercises;
using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs_Unit_Test
{
    public class MinimalTreeUnitTest
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
        public void MinimalTreeTest(int[] values, int expectedHeight)
        {
            Tree<int> tree = new Tree<int>();

            MinimalTree.CreateBinarySearchTree(tree, values);

            int result = tree.GetHeight(tree.root);

            Assert.Equal(expectedHeight, result);
        }
    }
}
