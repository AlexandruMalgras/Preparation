using Linked_Lists.Helpers;

namespace Linked_Lists.Exercises
{
    /*
     * Implement an algorithm to delete a node in the middle (any node but the first and last node, not necessarily
     * the exact middle) of a singly linked list, give only access to that node.
     */
    public static class DeleteMiddleNode
    {
        /*
         * The approach is straight forward. We check if the node is not the head or the tail of the linked list
         * and then we use the previously created method RemoveNode to delete the node from the linked list.
         */
        public static void DeleteMiddleNodeByCount(MyLinkedList<int> linkedList, MyNode<int> node)
        {
            if (node.Equals(linkedList.Head) || node.Equals(linkedList.Tail) || linkedList.Count == 0) return;

            linkedList.RemoveNode(node);
        }
    }
}
