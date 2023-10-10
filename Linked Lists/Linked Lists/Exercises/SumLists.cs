using Linked_Lists.Helpers;

namespace Linked_Lists.Exercises
{
    /*
     * You have two numbers represented by a linked list, where each node contains a single digit. The digits
     * are stored inn reverse order, such that the 1's digit is at the head of the list. Write a function that adds the two numbers and
     * returns the sum as a linked list. (You are not allowed to "cheat" and just convert the linked list to an integer.)
     * 
     * FOLLOW UP
     *
     * Suppose the digits are stored in forward order. Repeat the above problem.
     */
    public static class SumLists
    {
        /*
         * One approach is to start from the head of the lists and add the values of the nodes while keeping track of the
         * remainder of the calculation. A few notes, I decided to keep track of the lengthier list from the beginning to not have
         * to pad the shorter list with 0s on the go. Instead I just created a node that holds the value 0 and I am assigning the node
         * once the shorter linked list reached its end.
         */
        public static MyLinkedList<int> SumListsReverse(MyLinkedList<int> firstNumber, MyLinkedList<int> secondNumber)
        {
            MyLinkedList<int> temporary = new MyLinkedList<int>();

            MyNode<int> first = firstNumber.Count >= secondNumber.Count ? firstNumber.Head : secondNumber.Head;
            MyNode<int> second = firstNumber.Count < secondNumber.Count ? firstNumber.Head : secondNumber.Head;

            int calculation = 0;
            int remainder = 0;
            List<int> result = new List<int>();
            MyNode<int> emptyNode = new MyNode<int>(0);

            while (first != null)
            {
                calculation = first.Value + second.Value + remainder;

                if (calculation < 10)
                {
                    result.Add(calculation);
                    remainder = 0;
                }
                else
                {
                    result.Add(calculation % 10);
                    remainder = 1;
                }

                first = first.Next;
                second = second.Next != null ? second.Next : emptyNode;
            }

            if (remainder == 1) result.Add(remainder);

            for (int i = result.Count - 1; i >= 0; i--)
            {
                temporary.AppendToEnd(result[i]);
            }

            return temporary;
        }
        
        /*
         * Summing the lists forward gets a bit trickier because if we start calculating from the start we move to the right, but
         * the remainder moves to the left, so it gets harder to keep track. One way would be to use recursion to go towards the end of the
         * list, perform the calculations and move leftwards with the remainder, but I decided to pad the shorter list and create
         * placeholders and just reverse the linked lists. Yes, it uses extra memory for the 2 newly created linked lists
         * but it gets garbage collected once the method finishes executing. The same would apply using recursion as all the node calculations
         * would remain on the stack until completion.
         */
        public static MyLinkedList<int> SumListsForward(MyLinkedList<int> firstNumber, MyLinkedList<int> secondNumber)
        {
             int depth = Math.Abs(firstNumber.Count - secondNumber.Count);

            LeftPadLinkedList(firstNumber.Count >= secondNumber.Count ? secondNumber : firstNumber, depth, 0);

            MyNode<int> first = firstNumber.Head;
            MyNode<int> second = secondNumber.Head;

            MyLinkedList<int> newFirstNumber = new MyLinkedList<int>();
            MyLinkedList<int> newSecondNumber = new MyLinkedList<int>();

            for (int i = 0; i < firstNumber.Count; i++)
            {
                newFirstNumber.AppendToStart(first.Value);
                newSecondNumber.AppendToStart(second.Value);

                // We know the lists are equal in size.
                first = first.Next;
                second = second.Next;
            }

            return SumListsReverse(newFirstNumber, newSecondNumber);
        }

        private static void LeftPadLinkedList(MyLinkedList<int> linkedList, int depth, int value)
        {
            for (int i = 0; i < depth; i++)
            {
                linkedList.AppendToStart(value);
            }
        }
    }
}
