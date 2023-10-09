using Linked_Lists.Helpers;

namespace Linked_Lists.Exercises
{
    /*
     * Implement an algorithm to find the kth to last element of a singly linked list.
     */
    public static class ReturnKthToLast
    {
        /*
         * One method to find the kth to last element of a singly linked list is to apply the runner method
         * having two nodes that start at different locations and then move at the same speed.
         */
        public static int ReturnKthToLastWithRunner(MyLinkedList<int> linkedList ,int k)
        {
            if (k > linkedList.Count || k < 1) return -1;

            MyNode<int> slow = linkedList.Head;
            MyNode<int> fast = linkedList.Head;

            // Move the fast node k nodes ahead
            for (int i = 0; i < k; i++)
            {
                fast = fast.Next;
            }

            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow.Value;
        }

        /*
         * If we record the number of nodes in a singly linked list we can use the count to find the kth to last element.
         */
        public static int ReturnKthToLastWithCount(MyLinkedList<int> linkedList ,int k)
        {
            if (k > linkedList.Count || k < 1) return -1;

            MyNode<int> node = linkedList.Head;

            int depth = linkedList.Count - k;

            for (int i = 0; i < depth; i++)
            {
                node = node.Next;
            }

            return node.Value;
        }

        /*
         * If we record the tail of the list and the list is doubly linked we can also use that to find the kth to last element.
         */
        public static int ReturnKthToLastWithPrevious(MyLinkedList<int> linkedList ,int k)
        {
            if (k > linkedList.Count || k < 1) return -1;

            MyNode<int> node = linkedList.Tail;

            for (int i = 1; i < k; i++)
            {
                node = node.Previous;
            }

            return node.Value;
        }
    }
}
