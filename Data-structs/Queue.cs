using Data_structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Queue<T> : LinkedList<T> where T : IComparable<T>
    {
        private Node<T>? _tail;

        public override void Add(T value)
        {
            Node<T>? newNode = new Node<T>(value);

            if(_root != null)
            {
                _tail.Next = newNode;
            }
            else
            {
                _root = newNode; 
            }
            _tail = newNode;
        }

        public void Dequeue()
        {
            _root = _root != null ? _root.Next : null;
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

        public void Free() 
        {
            _root = null;
            _tail = null;
        }
    }
}
