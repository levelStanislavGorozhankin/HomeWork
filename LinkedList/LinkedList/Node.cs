using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LList
{
    class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(object data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public void Add(object data, Node headNode)
        {
            if (Next == null)
            {
                Next = new Node(data);
                Next.Previous = headNode;
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
