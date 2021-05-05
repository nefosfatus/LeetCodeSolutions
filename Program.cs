using LeetCodeSolutions.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ListNode n1 = new ListNode(1);
			ListNode n2 = new ListNode(2);
			ListNode n3 = new ListNode(3);
			ListNode n4 = new ListNode(4);
			ListNode n5 = new ListNode(5);

			n1.next = n2;
			n2.next = n3;
			n3.next = n4;
			n4.next = n1;

			LinkedListSolution.HasCycle(n1);
		}
	}
}

