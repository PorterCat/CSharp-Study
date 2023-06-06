namespace Data_structs
{
    internal class Node<T> where T : IComparable<T>
    {
        public T? Value;
        public Node<T>? Next;

        protected Node() { }

        public Node(Node<T> next, T value)
        {
            Value = value;
            Next = next;
        }

        public Node(T value)
        {
            Value = value;
        }
    }
}