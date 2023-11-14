namespace Test1
{
    abstract class LinkedList<T> where T : IComparable<T>
    {
        private abstract _root;
        public abstract void Print();
        public abstract void Add();
    }
}