using Linked_Lists.Helpers;

namespace Linked_Lists.Exercises
{
    /*
    * Write code to remove duplicates from an unsorted linked list.
    * FOLLOW UP
    * How would you solve this problem if a temporary buffer is not allowed?
    */
    public static class RemoveDups
    {
        /*
         * One way to approach this problem using a temporary buffer is to use a HashSet
         * to store the node values and then compare.
         */
        public static void RemoveDupsWithHashSet(MyLinkedList<int> list)
        {
            if (list.Head == null) return;

            HashSet<int> set = new HashSet<int>();

            MyNode<int> node = list.Head;

            while (node != null)
            {
                if (set.TryGetValue(node.Value, out int value))
                {
                    list.RemoveNode(node);
                }
                else
                {
                    set.Add(node.Value);
                }

                node = node.Next;
            }
        }

        /*
         * One way to approach this problem without using a temporary buffer which is not very indicated 
         * because of the time complexity is to use nested loops and keep track of the pointers.
         */
        public static void RemoveDupsWithNestedLoops(MyLinkedList<int> list)
        {
            MyNode<int> primary = list.Head;

            while (primary != null)
            {
                MyNode<int> secondary = primary.Next;

                while (secondary != null)
                {
                    if (primary.Value == secondary.Value)
                    {
                        list.RemoveNode(secondary);
                    }

                    secondary = secondary.Next;
                }

                primary = primary.Next;
            }
        }
    }
}
