using Data_structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Stack<T> where T : IComparable<T>
    {
        private Node<T>? _head;

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(_head, value);
            newNode.Next = _head;
            _head = newNode;
        }

        public void Pop() 
        {
            _head = _head != null ? _head.Next : null;
        }

        public T Peek()
        {
            return _head.Value;
        }

        public void PrintStack()
        {
            Node<T> temp = _head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void Free() => _head = null;

    }
}
