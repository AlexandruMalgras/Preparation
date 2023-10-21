using Trees_and_Graphs.Exercises;
using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs_Unit_Test
{
    public class CheckBalancedUnitTest
    {
        [Fact]
        public void IsBalanced_EmptyTree()
        {
            Tree<int> tree = new Tree<int>();

            bool result = CheckBalanced.IsBalanced(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsBalanced_SingleNodeTree()
        {
            Tree<int> tree = new Tree<int>();
            tree.root = new TreeNode<int>(5);

            bool result = CheckBalanced.IsBalanced(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsBalanced_BalancedTree()
        {
            Tree<int> tree = new Tree<int>();
            tree.root = new TreeNode<int>(1);
            tree.root.Left = new TreeNode<int>(2);
            tree.root.Right = new TreeNode<int>(3);
            tree.root.Left.Left = new TreeNode<int>(4);
            tree.root.Left.Right = new TreeNode<int>(5);
            tree.root.Right.Left = new TreeNode<int>(6);
            tree.root.Right.Right = new TreeNode<int>(7);

            bool result = CheckBalanced.IsBalanced(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsBalanced_UnbalancedTree()
        {
            Tree<int> tree = new Tree<int>();
            tree.root = new TreeNode<int>(1);
            tree.root.Left = new TreeNode<int>(2);
            tree.root.Right = new TreeNode<int>(3);
            tree.root.Left.Left = new TreeNode<int>(4);
            tree.root.Left.Left.Left = new TreeNode<int>(5);

            bool result = CheckBalanced.IsBalanced(tree);

            Assert.False(result);
        }
    }
}
