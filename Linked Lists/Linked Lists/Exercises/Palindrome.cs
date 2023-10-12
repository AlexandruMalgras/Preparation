using Linked_Lists.Helpers;

namespace Linked_Lists.Exercises
{
    /*
     * Implement a function to check if a linked list is a palindrome.
     */
    public static class Palindrome
    {
        /*
         * In a doubly linked linked list we can start from the head and the tail and compare the values of opposite nodes.
         */
        public static bool IsPalindromeWithDoublyLinked(MyLinkedList<int> linkedList)
        {
            MyNode<int> leftmost = linkedList.Head;
            MyNode<int> rightmost = linkedList.Tail;

            // Calculate the middle of the linked list.
            int depth = linkedList.Count / 2;

            // Check if the values of opposite nodes are the same.
            for (int i = 0; i < depth; i++) 
            {
                if (leftmost.Value != rightmost.Value) return false;

                leftmost = leftmost.Next;
                rightmost = rightmost.Previous;
            }

            return true;
        }

        /*
         * Another approach to check if opposite nodes are the same is to use recursion.
         * We start from the leftmost node in the linked list and we use a stop node (basic case null, the end of the linked list)
         * to compare opposite nodes.
         */
        public static bool IsPalindromeWithRecursion(MyLinkedList<int> linkedList, MyNode<int> left, MyNode<int> stopNode)
        {
            // Check if the left node reached the end in an even linked list.
            if (left == stopNode) return true;

            MyNode<int> right = left;
            
            // Advance with the right node until we reach the stop node
            while (right.Next != stopNode)
            {
                right = right.Next;
            }

            // Check if the left node is the same as the right node for an odd linked list.
            if (left == right) return true;

            // Compare the values
            if (left.Value != right.Value) return false;

            // Move to the next node
            left = left.Next;

            return IsPalindromeWithRecursion(linkedList, left, right);
        }
    }
}
