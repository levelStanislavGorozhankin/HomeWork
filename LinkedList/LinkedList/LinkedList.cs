using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LList
{
    class LList
    {
        public Node HeadNode { get; set; }

        public LList()
        {
            HeadNode = null;
        }

        public void Add(object data)
        {
            if (HeadNode == null)
                HeadNode = new Node(data);
            else
            {
                HeadNode.Add(data, HeadNode);
            }
        }

        public void Del()
        {
            if (HeadNode == null)
                return;

            if (HeadNode.Next != null)
            {
                HeadNode = HeadNode.Next;
                HeadNode.Previous = null;
            }
            else
                HeadNode = null;
        }

        public void Print()
        {
            if (HeadNode != null)
                HeadNode.Print();

            Console.WriteLine("Коллекция пуста");
        }
    }
}
