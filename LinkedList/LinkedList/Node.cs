using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LList
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public void Add(T data, Node<T> headNode)
        {
            if (Next == null)
            {
                Next = new Node<T>(data)
                {
                    Previous = headNode
                };
            }
            else
            {
                Next.Add(data, Next);
            }
        }

        public void Print()
        {
            Console.Write(Data + " -> ");
            if (Next != null)
            {
                Next.Print();
            }
        }

    }
}
