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
    }
}
