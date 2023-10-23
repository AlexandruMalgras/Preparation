using Trees_and_Graphs.Exercises;
using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs_Unit_Test
{
    public class ValidateBSTUnitTest
    {
        [Fact]
        public void ValidateBST_NullNode()
        {
            TreeNode<int> node = null;

            bool result = ValidateBST.IsValid(node, int.MinValue, int.MaxValue);

            Assert.True(result);
        }

        [Fact]
        public void ValidateBST_SingleNode() 
        {
            TreeNode<int> node = new TreeNode<int>(5);

            bool result = ValidateBST.IsValid(node, int.MinValue, int.MaxValue);

            Assert.True(result);
        } 

        [Fact]
        public void ValidateBST_NotValidLeft()
        {
            TreeNode<int> node = new TreeNode<int>(10);

            node.Left = new TreeNode<int>(9);
            node.Left.Left = new TreeNode<int>(8);
            node.Left.Right = new TreeNode<int>(11);

            node.Right = new TreeNode<int>(12);

            bool result = ValidateBST.IsValid(node, int.MinValue, int.MaxValue);

            Assert.False(result);
        }

        [Fact]
        public void ValidateBST_NotValidRight()
        {
            TreeNode<int> node = new TreeNode<int>(10);

            node.Left = new TreeNode<int>(9);

            node.Right = new TreeNode<int>(12);
            node.Right.Left = new TreeNode<int>(9);
            node.Right.Right = new TreeNode<int>(13);

            bool result = ValidateBST.IsValid(node, int.MinValue, int.MaxValue);

            Assert.False(result);
        }

        [Fact]
        public void ValidateBST_ValidLeft() 
        {
            TreeNode<int> node = new TreeNode<int>(10);

            node.Left = new TreeNode<int>(9);
            node.Left.Left = new TreeNode<int>(8);
            node.Left.Right = new TreeNode<int>(10);

            node.Right = new TreeNode<int>(12);

            bool result = ValidateBST.IsValid(node, int.MinValue, int.MaxValue);

            Assert.True(result);
        }

        [Fact]
        public void ValidateBST_ValidRight()
        {
            TreeNode<int> node = new TreeNode<int>(10);

            node.Left = new TreeNode<int>(9);

            node.Right = new TreeNode<int>(12);
            node.Right.Left = new TreeNode<int>(11);
            node.Right.Right = new TreeNode<int>(13);

            bool result = ValidateBST.IsValid(node, int.MinValue, int.MaxValue);

            Assert.True(result);
        }
    }
}
