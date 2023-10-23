using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs.Exercises
{
    /*
     * Implement a function to check if a binary tree is a binary search tree.
     */
    public static class ValidateBST
    {
        public static bool IsValid(TreeNode<int> node, int min, int max)
        {
            // Base case
            if (node == null) return true;

            // Compare values
            if (node.Value <= min || node.Value > max) return false;

            // Repeat for all the nodes
            return IsValid(node.Left, min, node.Value) && IsValid(node.Right, node.Value, max);
        }
    }
}
