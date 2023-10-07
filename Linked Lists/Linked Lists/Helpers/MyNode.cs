namespace Linked_Lists.Helpers
{
    public class MyNode<T>
    {
        public MyNode<T> Next { get; set; }
        public MyNode<T> Previous { get; set; }
        public T Value { get; set; }

        public MyNode(T value) 
        {
            this.Value = value;
        }
    }
}
