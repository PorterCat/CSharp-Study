using Data_structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Stack<T> : LinkedList<T> where T : IComparable<T>
    {

        public override void Add(T value)
        {
            Node<T> newNode = new Node<T>(_root, value);
            newNode.Next = _root;
            _root = newNode;
        }

        public void Pop() 
        {
            _root = _root != null ? _root.Next : null;
        }

        public T Peek()
        {
            return _root.Value;
        }

        public override void Print()
        {
            Node<T> temp = _root;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void Free() => _root = null;

    }
}
