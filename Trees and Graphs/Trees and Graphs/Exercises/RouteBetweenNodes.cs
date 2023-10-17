using Trees_and_Graphs.Helpers.Graph;

namespace Trees_and_Graphs.Exercises
{
    /*
     * Given a directed graph and two nodes (S and E), design an algorithm to find out whether there is a route from S to E.
     */
    public static class RouteBetweenNodes
    {
        /*
         * One method to check if we can reach the end node from the start node is to use breadth-first search.
         */
        public static bool RouteBetweenNodesWithBFS<T>(GraphNode<T> start, GraphNode<T> end)
        {
            if (start == null || end == null) return false;

            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            HashSet<GraphNode<T>> visited = new HashSet<GraphNode<T>>();

            // Add the start node to the queue
            queue.Enqueue(start);

            // Mark the start node as visited
            visited.Add(start);

            while (queue.Count > 0)
            {
                // Retrieve the first element from the queue
                GraphNode<T> current = queue.Dequeue();

                if (current == end) return true;

                // Check each node of the current element
                foreach (GraphNode<T> node in current.OutgoingNodes) 
                {
                    if (visited.Contains(node)) continue;

                    queue.Enqueue(node);
                    visited.Add(node);
                }
            }

            return false;
        }

        /*
        * One method to check if we can reach the end node from the start node is to use depth-first search.
        */
        public static bool RouteBetweenNodesWithDFS<T>(GraphNode<T> start, GraphNode<T> end)
        {
            if (start == null || end == null) return false;

            HashSet<GraphNode<T>> visited = new HashSet<GraphNode<T>>();

            return RouteBetweenNodesWithDFS(start, end, visited);
        }

        private static bool RouteBetweenNodesWithDFS<T>(GraphNode<T> start, GraphNode<T> end, HashSet<GraphNode<T>> visited)
        {
            if (start == end) return true;

            // Keep track of the visited nodes
            visited.Add(start);
            
            // Check the nodes at the next depth level
            foreach (GraphNode<T> node in start.OutgoingNodes)
            {
                if (visited.Contains(node)) continue;

                if (RouteBetweenNodesWithDFS(node, end, visited)) return true;
            }

            return false;
        }
    }
}
