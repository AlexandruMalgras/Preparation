using Linked_Lists.Helpers;

namespace Linked_Lists.Exercises
{
    /*
     * Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes
     * greater than or equal to x. The partition element x can appear anywhere in the right partition.
     */
    public static class Partition
    {
        /*
         * One way to approach this problem is to create 2 sepparate linked lists that will hold the lower and higher values.
         * Once the values are appended the lists are merged into the main list.
         */
        public static void PartitionWithLists(MyLinkedList<int> linkedList, int comparer)
        {
            if (linkedList.Count == 0) return;

            MyLinkedList<int> left = new MyLinkedList<int>();
            MyLinkedList<int> right = new MyLinkedList<int>();

            MyNode<int> node = linkedList.Head;

            // Append the nodes to the newly created lists
            while (node != null)
            {
                if (node.Value < comparer)
                {
                    left.AppendToEnd(node);
                }
                else
                {
                    right.AppendToEnd(node);
                }

                node = node.Next;
            }

            // Merge linked lists
            if (left.Tail != null && right.Head != null)
            {
                left.Tail.Next = right.Head;
                right.Head.Previous = left.Tail;

                linkedList.Head = left.Head;
                linkedList.Tail = right.Tail;
            }
            else if (left.Tail != null && right.Head == null)
            {
                linkedList.Head = left.Head;
                linkedList.Tail = left.Tail;
            }
            else
            {
                linkedList.Head = right.Head;
                linkedList.Tail = right.Tail;
            }
        }
    }
}
