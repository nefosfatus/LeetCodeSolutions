using System;

namespace LeetCodeSolutions.LinkedList
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }
        public int Value { get; }
        public Node NextNode { get; set; }
    }
    public class LinkedList
    {
        private Node Head { get; set; }
        private int? nodesCount;

        public Node GetNode(int index)
        {

            if (nodesCount < 0 || Head == null || index < 0 || index > nodesCount)
                return null;

            Node currentNode = Head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var node = GetNode(index);

            if (node == null)
                return -1;

            return node.Value;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newHead = new Node(val);
            newHead.NextNode = Head;
            Head = newHead;
            nodesCount++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                AddAtHead(val);
            }

            Node current = Head;
            while (current.NextNode != null)
            {
                current = current.NextNode;
            }
            current.NextNode = new Node(val);
            nodesCount++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > nodesCount || index < 0)
            {
                return;
            }

            if (index == nodesCount)
            {
                AddAtTail(val);
                return;
            }

            Node current = GetNode(index);
            Node prev = GetNode(index - 1);

            if (prev == null)
            {
                AddAtHead(val);
                return;
            }

            Node newNode = new Node(val);

            prev.NextNode = newNode;
            newNode.NextNode = current;

            nodesCount++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            Node current = GetNode(index);

            if (current == null)
            {
                return;
            }


            Node prev = GetNode(index - 1);

            if (prev == null)
            {
                Head = Head.NextNode;
                return;
            }

            Node next = current.NextNode;

            prev.NextNode = next;

            nodesCount--;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public static class LinkedListSolution
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }


            ListNode firstPointer = head;
            ListNode secondPointer = head;
            
           
        }
    }
}
