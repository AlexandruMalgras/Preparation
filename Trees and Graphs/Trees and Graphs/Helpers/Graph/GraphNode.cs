namespace Trees_and_Graphs.Helpers.Graph
{
    public class GraphNode<T>
    {
        public T Value { get; set; }
        public List<GraphNode<T>> OutgoingNodes { get; set; }

        public GraphNode(T value)
        {
            this.Value = value;
            this.OutgoingNodes = new List<GraphNode<T>>();
        }

        public void AddOutgoingNodes(List<GraphNode<T>> outgoingNodes)
        {
            foreach (GraphNode<T> node in outgoingNodes)
            {
                this.OutgoingNodes.Add(node);
            }
        }
    }
}
