using Trees_and_Graphs.Exercises;
using Trees_and_Graphs.Helpers.Graph;

namespace Trees_and_Graphs_Unit_Test
{
    public class RouteBetweenNodesUnitTest
    {
        public static GraphNode<int> node1 = new GraphNode<int>(10);
        public static GraphNode<int> node2 = new GraphNode<int>(20);
        public static GraphNode<int> node3 = new GraphNode<int>(30);
        public static GraphNode<int> node4 = new GraphNode<int>(40);
        public static GraphNode<int> node5 = new GraphNode<int>(50);

        private static void ClearNodes()
        {
            node1.OutgoingNodes.Clear();
            node2.OutgoingNodes.Clear();
            node3.OutgoingNodes.Clear();
            node4.OutgoingNodes.Clear();
            node5.OutgoingNodes.Clear();
        }

        private static void AddOutgoings(List<GraphNode<int>> node1Outgoings, List<GraphNode<int>> node2Outgoings,
            List<GraphNode<int>> node3Outgoings, List<GraphNode<int>> node4Outgoings, List<GraphNode<int>> node5Outgoings)
        {
            node1.AddOutgoingNodes(node1Outgoings);
            node2.AddOutgoingNodes(node2Outgoings);
            node3.AddOutgoingNodes(node3Outgoings);
            node4.AddOutgoingNodes(node4Outgoings);
            node5.AddOutgoingNodes(node5Outgoings);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new List<GraphNode<int>>() { node2 },
                new List<GraphNode<int>>() { node3 },
                new List<GraphNode<int>>() { node4 },
                new List<GraphNode<int>>() { node5 },
                new List<GraphNode<int>>() { },
                node1,
                node5,
                true
            };

            yield return new object[]
            {
                new List<GraphNode<int>>() { node2 },
                new List<GraphNode<int>>() { node1 },
                new List<GraphNode<int>>() { node4 },
                new List<GraphNode<int>>() { node5 },
                new List<GraphNode<int>>() { },
                node1,
                node5,
                false
            };

            yield return new object[]
            {
                new List<GraphNode<int>>() { node2, node5 },
                new List<GraphNode<int>>() { node1 },
                new List<GraphNode<int>>() { node4 },
                new List<GraphNode<int>>() { node5 },
                new List<GraphNode<int>>() { },
                node1,
                node5,
                true
            };

            yield return new object[]
            {
                new List<GraphNode<int>>() { node2, node5 },
                new List<GraphNode<int>>() { node1 },
                new List<GraphNode<int>>() { node4 },
                new List<GraphNode<int>>() { node5 },
                new List<GraphNode<int>>() { },
                null,
                null,
                false
            };

            yield return new object[]
            {
                new List<GraphNode<int>>() { node2, node5 },
                new List<GraphNode<int>>() { node1 },
                new List<GraphNode<int>>() { node4 },
                new List<GraphNode<int>>() { node5 },
                new List<GraphNode<int>>() { },
                null,
                node5,
                false
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RouteBetweenNodesWithBFSTest(List<GraphNode<int>> node1Outgoings, List<GraphNode<int>> node2Outgoings,
            List<GraphNode<int>> node3Outgoings, List<GraphNode<int>> node4Outgoings, List<GraphNode<int>> node5Outgoings,
            GraphNode<int> start, GraphNode<int> end, bool expected)
        {
            ClearNodes();

            AddOutgoings(node1Outgoings, node2Outgoings, node3Outgoings, node4Outgoings, node5Outgoings);

            bool hasPath = RouteBetweenNodes.RouteBetweenNodesWithBFS(start, end);

            Assert.Equal(expected, hasPath);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void RouteBetweenNodesWithDFSTest(List<GraphNode<int>> node1Outgoings, List<GraphNode<int>> node2Outgoings,
            List<GraphNode<int>> node3Outgoings, List<GraphNode<int>> node4Outgoings, List<GraphNode<int>> node5Outgoings,
            GraphNode<int> start, GraphNode<int> end, bool expected)
        {
            ClearNodes();

            AddOutgoings(node1Outgoings, node2Outgoings, node3Outgoings, node4Outgoings, node5Outgoings);

            bool hasPath = RouteBetweenNodes.RouteBetweenNodesWithDFS(start, end);

            Assert.Equal(expected, hasPath);
        }
    }
}