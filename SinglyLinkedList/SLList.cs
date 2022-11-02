using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class SLList<T>
    {
        public GenericNode<T>? Head { get; set; }

        public SLList()
        {
            Head = null;
        }

        public void InsertFirst(T t)
        {
            GenericNode<T> tmp = new();
            tmp.Value = t;
            tmp.Next = Head;

            Head = tmp;
        }

        public GenericNode<T>? RemoveFirst()
        {
            GenericNode<T> tmp = Head!;
            if (Head != null) Head = Head!.Next;
            return tmp;
        }

        public void InsertLast(T t)
        {
            if (Head == null)
            {
                InsertFirst(t);
                return;
            }

            GenericNode<T> tmp = new();
            tmp.Value = t;
            tmp.Next = null;

            for (GenericNode<T> node = Head; node.Next != null; node = node.Next)
            {
                node.Next = tmp;
            }
        }

        public GenericNode<T>? RemoveLast()
        {
            if (Head is null)
            {
                return null;
            }

            if (Head.Next is null)
            {
                return RemoveFirst();
            }

            GenericNode<T> node;
            for ( node = Head; node.Next!.Next != null; node = node.Next)
            {

            }

            GenericNode<T> tmp = node.Next;
            node.Next = null;
            return tmp;
        }

        public void Traverse()
        {
            if (Head == null)
            {
                throw new Exception();
            }
            for (GenericNode<T> node = Head!; node.Next != null; node = node.Next)
            {
                Console.WriteLine($"value: {node.Value}");
            }
        }
    }
}
