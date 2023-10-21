using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs.Exercises
{
    /*
     * Implement a function to check if a binary tree is balanced. For the purposes of this question,
     * a balanced tree is defined to be a tree such that the heights of the two subtrees of any node
     * never differ by more than one.
     */
    public static class CheckBalanced
    {
        /*
         * To check if a tree is balanced I used a combination of DFS and BFS
         */
        public static bool IsBalanced<T>(Tree<T> tree)
        {
            // DFS to find the maximum height of the tree
            int maximum = tree.GetHeight(tree.root);

            // If the maximum height is 0 return without checking the minimum
            if (maximum == 0) return true;

            // BFS to find the minimum height of the tree
            int minimum = tree.GetMinimumHeight(tree.root);

            int result = maximum - minimum;

            return result > 1 ? false : true;
        }
    }
}
