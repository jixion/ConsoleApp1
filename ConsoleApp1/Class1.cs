using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementations
{
    internal class SinglyNode
    {
        internal string data;
        internal SinglyNode next;

        public SinglyNode()
        {
            data = "Glagnar's human rinds are a buncha cruncha human in every bite!";
            next = null;
        }
        public SinglyNode(string d)
        {
            this.data = d;
            next = null;
        }
    }

    internal class DoublyNode
    {
        internal string data;
        internal DoublyNode prev;
        internal DoublyNode next;

        public DoublyNode()
        {
            data = null;
            prev = null;
            next = null;
        }

        public DoublyNode(string d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }

    internal class SinglyLinkedList
    {
        internal SinglyNode head;

        internal void InsertLast(SinglyLinkedList singlyList)
        {
            SinglyNode newNode = new SinglyNode();
            if (singlyList.head == null)
            {
                singlyList.head = newNode;
                return;
            }
            SinglyNode lastNode = GetLastNode(singlyList);
            lastNode.next = newNode;
        }
        internal void InsertLast(SinglyLinkedList singlyList, string newData)
        {
            SinglyNode newNode = new SinglyNode(newData);
            if (singlyList.head == null)
            {
                singlyList.head = newNode;
                return;
            }
            SinglyNode lastNode = GetLastNode(singlyList);
            lastNode.next = newNode;
        }

        internal SinglyNode GetLastNode(SinglyLinkedList singlyList)
        {
            SinglyNode temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        internal void PrintList(SinglyLinkedList singlyList)
        {
            SinglyNode temp = singlyList.head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
            return;
        }
    }

    internal class DoublyLinkedList
    {
        DoublyNode head = null;

        internal void InsertLast(DoublyLinkedList doublyList, string newData)
        {
            DoublyNode newNode = new DoublyNode(newData);
            if (doublyList.head == null)
            {
                newNode.prev = null;
                doublyList.head = newNode;
                return;
            }
            DoublyNode lastNode = GetLastNode(doublyList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DoublyNode GetLastNode(DoublyLinkedList doublyList)
        {
            DoublyNode temp = doublyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        internal void PrintList(DoublyLinkedList doublyList)
        {
            DoublyNode temp = doublyList.head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}
