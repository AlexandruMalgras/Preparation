namespace Linked_Lists.Helpers
{
    public class MyLinkedList<T>
    {
        public MyNode<T> Head { get; set; }
        public MyNode<T> Tail { get; set; }
        public int Count { get; private set; }

        public MyLinkedList() 
        {
            this.Count = 0;
        }

        public void AppendToFront(T value)
        {
            if (this.Head == null)
            {
                this.InitializeLinkedList(value);
                return;
            }

            MyNode<T> newNode = new MyNode<T>(value);

            this.Tail.Next = newNode;
            newNode.Previous = this.Tail;
            this.Tail = newNode;
            this.Count++;
        }

        private void InitializeLinkedList(T value)
        {
            this.Head = new MyNode<T>(value);
            this.Tail = this.Head;
            this.Count++;
        }

        public void RemoveNode(MyNode<T> node)
        {
            if (!this.CheckIfNodeExists(node))
            {
                Console.WriteLine("The node is not present in the Linked List.");
                return;
            }

            if (node.Next == null && node.Previous == null)
            {
                this.Head = null;
                this.Tail = null;
                this.Count--;
                return;
            }

            if (node.Previous == null)
            {
                this.Head = node.Next;
                this.Head.Previous = null;
                this.Count--;
                return;
            }

            if (node.Next == null)
            {
                this.Tail = node.Previous;
                this.Tail.Next = null;
                this.Count--;
                return;
            }

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            this.Count--;
        }

        public bool CheckIfNodeExists(MyNode<T> node)
        {
            MyNode<T> tmp = this.Head;

            while (tmp != null)
            {
                if (node == tmp) return true;

                tmp = tmp.Next;
            }

            return false;
        }
    }
}
