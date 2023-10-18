using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs.Exercises
{
    /*
     * Given a sorted (Increasing order) array with unique integer elements, write an algorithm to
     * create a binary search tree with minimal height.
     */
    public static class MinimalTree
    {
        public static Tree<int> CreateBinarySearchTree(Tree<int> tree, int[] values)
        {
            if (values.Length == 0 || values == null) return null;

            tree.root = CreateBinarySearchTree(values, 0, values.Length - 1);

            return tree;
        }

        private static TreeNode<int> CreateBinarySearchTree(int[] values, int start, int end)
        {
            if (start > end) return null;

            // Get the middle of the array
            int middle = (start + end) / 2;

            // Create a node with the value of the middle of the array
            TreeNode<int> node = new TreeNode<int>(values[middle]);

            // Create the left child
            node.Left = CreateBinarySearchTree(values, start, middle - 1);

            // Create the right child
            node.Right = CreateBinarySearchTree(values, middle + 1, end);

            return node;
        }
    }
}
