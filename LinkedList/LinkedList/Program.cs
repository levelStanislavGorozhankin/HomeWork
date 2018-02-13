using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LList
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList lnkList = new LinkedList();

            //Node myNode = new Node("1n");
            //   myNode.Add("1n");
            //myNode.Add("2n");
            //myNode.Add("3n");
            //myNode.Add("4n");
            //       myNode.Print();
            //Console.WriteLine("\n----------------");
            //Console.WriteLine(myNode.Data);
            //Console.WriteLine(myNode.Next.Data);
            //Console.WriteLine(myNode.Next.Pervious.Data);
            //     myNode.Print();
            //    Console.WriteLine("\n----------------");
            //    Console.WriteLine(myNode.Pervious);
            //   Console.WriteLine(myNode.Next.Next.Pervious);
            ////myNode.Pervious.Data = "sdf";
            ////Console.WriteLine(myNode.Pervious);
            //    Console.WriteLine();

            LList<string> myList = new LList<string>();
            myList.Print();
            Console.WriteLine("test");
            myList.Add("1n");
            myList.Add("2n");
            myList.Add("3n");
            myList.Add("4n");

            Console.WriteLine(myList.HeadNode.Data); Console.WriteLine(myList.HeadNode.Previous);
            Console.WriteLine(myList.HeadNode.Next.Data);
            Console.WriteLine(myList.HeadNode.Next.Previous.Data);

            Console.WriteLine(myList.HeadNode.Next.Next.Next.Data);
            Console.WriteLine(myList.HeadNode.Next.Next.Next.Previous.Data);
            //myList.Add("4n");
            //      myList.Print();
            //     Console.WriteLine("\n");
            //  Console.WriteLine(myList.HeadNode.Next.Next.Pervious.Data);

            Console.WriteLine("4 element added ----------------");
            Console.WriteLine(myList.HeadNode.Data);
            myList.Del();
            Console.WriteLine("\n1st del----------------");
            myList.Print();
            Console.WriteLine("-----------");
            Console.WriteLine(myList.HeadNode.Data);
            Console.WriteLine(myList.HeadNode.Previous);
            Console.WriteLine(myList.HeadNode.Next.Data);
            Console.WriteLine(myList.HeadNode.Next.Previous.Data);
            Console.WriteLine("-----------");
            myList.Del();
            Console.WriteLine("\n2nd del----------------");
            myList.Print();
            myList.Del();
            Console.WriteLine("\n3d del----------------");
            myList.Print();

            myList.Del();
            Console.WriteLine("\n4th del----------------");
            myList.Print();
            myList.Del();
            myList.Print();
            myList.Del();
            myList.Print();
            myList.Del();
            myList.Print();
            List<int> nn = new List<int>();
            
            LList<int> myListInt = new LList<int>();
            myListInt.Add(8);
            myListInt.Add(10);
            myListInt.Print();
        }
    }
}
