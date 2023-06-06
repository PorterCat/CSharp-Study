using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structs
{
    internal class DoublyNode<T> : Node<T> where T : IComparable<T>
    {
        public Node<T>? Previous;

        public DoublyNode(T value) : base(value) { }

        //Добро пожаловать в палату
        public DoublyNode(Node<T> next, Node<T> previous, T value) : base(next, value)
        {
            Previous = previous;
        }
        public DoublyNode(Node<T>? previous, T value) : base(value)
        {
            Previous = previous;
        }
    }
}
