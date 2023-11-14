namespace Data_structs
{
    internal class Node<T> where T : IComparable<T>
    {
        public T? Value;
        public Node<T>? Next;

        protected Node() { }

        public Node(T value)
        {
            Value = value;
        }
    }
}