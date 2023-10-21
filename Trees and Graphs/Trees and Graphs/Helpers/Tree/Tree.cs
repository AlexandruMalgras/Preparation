namespace Trees_and_Graphs.Helpers.Tree{
    public class Tree<T>
    {
        public TreeNode<T> root { get; set; }

        public Tree()
        {
            this.root = null;
        }

        public int GetHeight(TreeNode<T> node)
        {
            if (node == null) return 0;

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public int GetMinimumHeight(TreeNode<T> node)
        {
            if (node == null) return 0;

            int height = 0;

            LinkedList<TreeNode<T>> nodes = new LinkedList<TreeNode<T>>();
            HashSet<TreeNode<T>> visited = new HashSet<TreeNode<T>>();

            // Add the node to the linked list
            nodes.AddLast(node);

            // Mark the node as visited
            visited.Add(node);

            while (nodes.Count > 0)
            {
                // Increase the height
                height++;

                // Linked list to check the nodes per level
                LinkedList<TreeNode<T>> parents = nodes;

                // Empty the linked list to add the children
                nodes = new LinkedList<TreeNode<T>>();

                foreach (TreeNode<T> n in parents)
                {
                    // return the height - 1 because we incremented 1 on a level that has a null node
                    if (n == null) return height - 1;

                    // Add left child
                    if (!visited.Contains(n.Left))
                    {
                        nodes.AddLast(n.Left);
                        visited.Add(n.Left);
                    }

                    // Add right child
                    if (!visited.Contains(n.Right))
                    {
                        nodes.AddLast(n.Right);
                        visited.Add(n.Right);
                    }
                }
            }

            // Should never reach this return
            return 0;
        }
    }
}
