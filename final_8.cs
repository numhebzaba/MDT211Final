using System;

namespace Final_8
{
    class Node
    {
        public string Value;
        public Node Next;

        public Node(string value)
        {
            Value = value;
            Next = null;
        }
    }
    class Stack
    {
        private Node root;

        public void Push(Node node)
        {
            if (IsRootNull())
            {
                root = node;
            }
            else
            {
                node.Next = root;
                root = node;
            }
        }

        public Node Pop()
        {
            Node node = root;
            root = root.Next;
            node.Next = null;
            return node;
        }

        public bool IsRootNull()
        {
            return root is null;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Stack productionLine = new Stack();
            Stack assembleLine = new Stack();
            Stack tempStock = new Stack();

            int targetNumberOfProduct = int.Parse(Console.ReadLine());
            int numberOfProduct = 0;

            while (numberOfProduct<targetNumberOfProduct)
            {
                string part = Console.ReadLine();
                Node node = new Node(part);

                productionLine.Push(node);
            }
            

        }
    }
}
