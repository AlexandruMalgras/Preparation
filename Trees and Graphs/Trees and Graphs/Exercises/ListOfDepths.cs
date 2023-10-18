using Trees_and_Graphs.Helpers.Tree;

namespace Trees_and_Graphs.Exercises
{
    /*
     * Given a binary tree, design an algorithm which creates a linked list of all the nodes at each depth
     * (e.g., if you have a tree with depth D, you'll have D linked lists).
     */
    public static class ListOfDepths
    {
        public static List<LinkedList<TreeNode<T>>> ListOfDepthsWithBFS<T>(Tree<T> tree)
        {
            if (tree.root == null || tree == null) return null;

            List<LinkedList<TreeNode<T>>> linkedLists = new List<LinkedList<TreeNode<T>>>();

            LinkedList<TreeNode<T>> current = new LinkedList<TreeNode<T>>();

            current.AddLast(tree.root);

            // Loop as long as there are children
            while (current.Count > 0)
            {
                linkedLists.Add(current);

                // Move to the next depth
                LinkedList<TreeNode<T>> parents = current;

                // Empty the current list
                current = new LinkedList<TreeNode<T>>();

                // Add the children to the current list
                foreach (TreeNode<T> node in parents)
                {
                    if (node.Left != null) current.AddLast(node.Left);
                    if (node.Right != null) current.AddLast(node.Right);
                }
            }

            return linkedLists;
        }


        public static List<LinkedList<TreeNode<T>>> ListOfDepthsWithDFS<T>(Tree<T> tree)
        {
            if (tree.root == null || tree == null) return null;

            List<LinkedList<TreeNode<T>>> linkedLists = new List<LinkedList<TreeNode<T>>>();

            ListOfDepthsWithDFS(linkedLists, tree.root, 0);

            return linkedLists;
        }

        private static void ListOfDepthsWithDFS<T>(List<LinkedList<TreeNode<T>>> linkedLists, TreeNode<T> node, int depth)
        {
            // Base case
            if (node == null) return;

            // Create the linked list if it does not already exist
            if (linkedLists.Count == depth)
            {
                linkedLists.Add(new LinkedList<TreeNode<T>>());
            }

            // Assign the node to the linked list
            linkedLists[depth].AddLast(node);

            // Recur for the rest of the nodes
            ListOfDepthsWithDFS(linkedLists, node.Left, depth + 1);
            ListOfDepthsWithDFS(linkedLists, node.Right, depth + 1);
        }
    }
}
