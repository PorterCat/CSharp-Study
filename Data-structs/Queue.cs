using Data_structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Queue<T> where T : IComparable<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;

        public void Enqueue(T value)
        {
            Node<T>? newNode = new Node<T>(value);

            if(_head != null)
            {
                _tail.Next = newNode;
            }
            else
            {
                _head = newNode; 
            }
            _tail = newNode;
        }

        public void Dequeue()
        {
            _head = _head != null ? _head.Next : null;
        }

        public void PrintQueue()
        {
            Node<T> temp = _head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void Free() 
        {
            _head = null;
            _tail = null;
        }
    }
}
