namespace Trees_and_Graphs.Helpers.Tree
{
    public class TreeNode<T>
    {
        public T Value { get; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
        }
    }
}
