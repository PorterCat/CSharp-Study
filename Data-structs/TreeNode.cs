namespace Data_structs
{
    internal class TreeNode<T> where T : IComparable<T>
    {
        public T? Value;
        public TreeNode<T>? Left;
        public TreeNode<T>? Right;


        protected TreeNode() { }

        public TreeNode(T value, TreeNode<T> left, TreeNode<T>? right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public TreeNode(T value)
        {
            Value = value;
        }
    }
}