using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("inserted into the linked list   " + node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine( "Display Data  " + temp.data + " ");
                temp = temp.next;
            }
        }
        public void AppendNew(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("After Append in linked list " + data); 
            }

        }
        public Node InsertAtParticularPoistion(int poistion, int data)
        {
            if (poistion < 1)
                Console.WriteLine("Invalid Poistion");
            if (poistion == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (poistion-- != 0)
                {
                    if (poistion == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (poistion != 1)
                    Console.WriteLine("poistion out of range");
            }
            return head;
        }
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("Delete First Node " + deleteNode);
            return deleteNode;
            
        }
        public Node removeLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Node lastElement = newNode.next;
            Console.WriteLine("Remove LAst Node  " + lastElement.data);
            newNode.next = null;

            return lastElement;
           
        }
    }
}
    

