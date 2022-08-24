using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        public Node head;

        public void Insert(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                head = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = newItem;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
