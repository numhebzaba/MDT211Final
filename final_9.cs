using System;

namespace final_9
{
    class Node
    {
        public Node Left;
        public Node Right;
        public Node Next;
        public string Name;

        public Node(string nameValue)
        {
            Name = nameValue;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    class Queue
    {
        private Node root;

        public void Push(Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node ptr = root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = node;
            }
        }

        public Node Pop()
        {
            Node node = root;
            if (root != null)
            {
                root = root.Next;
                node.Next = null;
            }
            return node;
        }

        public int GetLength()
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                Node ptr = root;
                int length = 1;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                    length++;
                }
                return length;
            }
        }

        public override string ToString()
        {
            string message = "";
            if (root != null)
            {
                Node ptr = root;
                message = message + "," + root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                    message = message + "," + ptr;
                }
            }
            return message;
        }

        public int CheckskillPoint(Node skillName)
        {
            Node node = root;
            int skillpointUse = 0;
            while (true)
            {
                if (root != null)
                {
                    if(root == skillName)
                    {
                        skillpointUse++;
                    }
                    root = root.Next;
                }
                else // root = null
                {
                    return 0;
                }
            }
            return skillpointUse;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue skillQueue = new Queue();
            int skillPointUse = 0;

            Console.WriteLine("Input skill name:");
            string skillName = Console.ReadLine();
            if(skillName == "?")
            {
                while (true)
                {
                    string skillUp = Console.ReadLine();
                    if (skillUp == "?")
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Add dependency for {0} ?  (Y/N) :",skillName);
                char ans = char.Parse(Console.ReadLine());
                if(ans == 'Y')
                {
                    Node node = new Node(skillName);
                    skillQueue.Push(node);

                    Console.WriteLine("Input skill name:");
                    string nextSkillName = Console.ReadLine();
                    Console.WriteLine("Add dependency for {0} ?  (Y/N) :", nextSkillName);
                    char nextAns = char.Parse(Console.ReadLine());
                    if (nextAns == 'Y')
                    {

                    }
                    else if(nextAns == 'N')
                    {

                    }


                }
                else if(ans == 'N')
                {

                }
            }
        }
    }
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ                  
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ                               
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ            
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ            
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ             
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ              
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ                 
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ           
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ        
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ           
    // ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ ยงธงขาวค้าบบบ
    //
    //
    //
    //
    //
    //
}
