using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001.SingleLinkedList
{
    internal class SingleLinkedList
    {
		private Node start;

		public SingleLinkedList()
		{
			start = null;
		}
		//1
		public void CreateLinkedList()
		{
			int n, i, x;
			Console.Write("Enter the number of nodes in the list: ");
			n = Convert.ToInt32(Console.ReadLine());

			for (i = 0; i < n; i++)
			{
				Console.Write("Enter the element at position " + i + " : ");
				x = Convert.ToInt32(Console.ReadLine());
				InsertNodeAtEnd(x);
				Console.WriteLine();
			}
		}

		//2
		public void DisplayList()
		{
			Node p;
			//Step 1 : if the list is empty
			if (start == null)
			{
				Console.WriteLine("The list is empty");
				return;
			}

			Console.Write("The linked list now is:");

			//Step 2: If the list is not empty		
			p = start;
			while (p != null)
			{
				Console.Write("  " + p.info);
				p = p.link;
			}
		}

		//3
		public void Count()
		{
			Node p;
			int i = 0;
			//Step 1 : if the list is empty
			if (start == null)
			{
				Console.WriteLine("The list is empty");
				return;
			}

			//Step 2: If the list is not empty		
			p = start;
			while (p != null)
			{
				i++;
				p = p.link;
			}

			Console.Write("Number of nodes in the list is: " + i);
		}

		//4
		public void InsertNodeAtEnd(int x)
		{
			Node p;
			//Step 1: create a new node with x
			Node temp = new Node(x);

			//Step 2: If list is empty
			if (start == null)
			{
				start = temp;
				return;
			}

			//Step 2: If list is not empty
			p = start;
			while (p.link != null)
				p = p.link;
			p.link = temp;
		}

		//5
		public void InsertNodeAtTheBeginning(int x)
		{
			Node p;
			//Step 1: create a new node with x
			Node temp = new Node(x);

			//Step 2: If list is empty
			if (start == null)
			{
				start = temp;
				return;
			}

			//Step 2: If list is not empty
			temp.link = start;
			start = temp;
		}

		//6
		public void InsertAfterNode(int x, int i)
		{
			Node p;
			//Step 1: create a new node with x
			Node temp = new Node(x);

			//Step 2: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty. Node cannot be inserted after " + i);
				return;
			}

			//Step 2: If list is not empty		
			p = start;
			while (p != null)
			{
				if (p.info == i)
				{
					//Step 3: If the node to insert after is found
					temp.link = p.link;
					p.link = temp;
					return;
				}
				p = p.link;
			}

			//step 4: If node i is not found
			if (p == null)
				Console.WriteLine("Node " + i + " not found. Node " + x + " cannot be inserted");
		}

		//7
		public void InsertBeforeNode(int x, int i)
		{
			Node p;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty. Node cannot be inserted before " + i);
				return;
			}

			//Step 2: create a new node with x
			Node temp = new Node(x);

			//Step 3: If list is not empty		

			//Step 4: If search element is the first element
			if (start.info == i)
			{
				temp.link = start;
				start = temp;
				return;
			}

			//step 5: if search element is not the first element or list has more than one element
			p = start;
			while (p.link != null)
			{
				if (p.link.info == i)
				{
					//Step 3: If the node to insert after is found
					temp.link = p.link;
					p.link = temp;
					return;
				}
				p = p.link;
			}

			//step 4: If node i is not found
			//covers case when list has only one element and element is not equal to search element
			//also case where search element does not exist in the list and new node cannot be inserted
			Console.WriteLine("Node " + i + " not found. Node " + x + " cannot be inserted");
		}

		//8
		public void InsertAtPosition(int x, int i)
		{
			Node p;
			int position;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty. Node cannot be inserted");
				return;
			}

			//Step 2: create a new node with x
			Node temp = new Node(x);

			//Step 3: if position is 1st position
			if (i == 1)
			{
				temp.link = start;
				start = temp;
				return;
			}

			//Step 3: If position is not 1st position	
			p = start;
			position = 1;
			while (p.link != null)
			{
				position++;
				if (position == i)
				{
					temp.link = p.link;
					p.link = temp;
					return;
				}

				p = p.link;
			}

			Console.WriteLine("Position " + i + " not found. Node " + x + " cannot be inserted");
		}

		//9
		public void SearchNodeAndListPosition(int x)
		{
			Node p;
			int position = 0;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			//step 2: if list is not empty
			p = start;
			while (p != null)
			{
				position++;
				if (p.info == x)
					break;
				p = p.link;
			}

			if (p == null)
				Console.WriteLine("Node not found in the list");
			else
				Console.WriteLine("Node found at position " + position + " in the list");
		}

		//10
		public void DeleteNodeWithValue(int x)
		{
			Node p;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			//If node to be deleted is first node
			if (start.info == x)
			{
				start = start.link;
				return;
			}

			//step 2: if list is not empty
			p = start;
			while (p.link != null)
			{
				if (p.link.info == x)
				{
					p.link = p.link.link;
					return;
				}
				p = p.link;
			}

			Console.WriteLine("Node not found in the list");
		}

		//11
		public void DeleteLastNode()
		{
			Node p;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			//step 3: if list has less than two nodes
			//Step 3.1: if list has only one node
			if (start.link == null)
				start = null;

			//Step 3.2: If list has only 2 nodes | MAY NOT BE NEEDED
			//if(start.link.link == null)
			//start.link = null;

			//step 4: if list has more than 2 nodes
			p = start;
			while (p.link.link != null)
				p = p.link;
			p.link = null;
		}
		//12
		public void DeleteFirstNode()
		{
			Node p;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			start = start.link;
		}

		//13
		public void ReverseLinkedList()
		{
			Node p, prev, next;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			p = start;
			prev = null;
			while (p != null)
			{

				next = p.link;
				p.link = prev;
				prev = p;
				p = next;
			}

			start = prev;
			Console.WriteLine("The reversed linked list is: ");
			DisplayList();
		}

		//14
		public void BubbleSortUsingLinkExchange()
		{
			Node p, q, r, end, temp;

			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			//Step 2: We need two loops, one running from end null to end != start.link, which will a cycle through
			//which highest among the first two elements is moved to the end.
			for (end = null; end != start.link; end = p)
			{
				//Step 3: In each cycle we need another loop where we compare 2 elements until we reach end so highest is moved to end
				for (r = p = start; p.link != end; r = p, p = p.link)
				{
					//step 4: set q as the next element
					q = p.link;

					//step 5: exchange links if current node is greater than next node
					if (p.info > q.info)
					{
						p.link = q.link;
						q.link = p;

						//step 5: if p is first element then after link exchange make q as first element
						//if p is not first element then set new previous element after link exchange
						//since after link exchange q's position moves earlier to P the new previous 
						//element r would be q
						if (p != start)
							r.link = q;
						else
							start = q;

						//step 6: Most important. Once the links are exchanged. We need to set P and Q values correctly
						//so that the next iteration will correctly compare the next two nodes
						temp = p;
						p = q;
						q = temp;

					}
				}
			}

			DisplayList();
		}

		//15
		public void BubbleSortUsingDataExchange()
		{
			Node p, q, end;
			//Step 1: If list is empty
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			//Step 2: We need two loops, one running from end null to end != start.link, which will a cycle through
			//which highest among the first two elements is moved to the end.
			for (end = null; end != start.link; end = p)
			{
				for (p = start; p.link != end; p = p.link)
				{
					q = p.link;
					if (p.info > q.info)
					{
						int temp = p.info;
						p.info = q.info;
						q.info = temp;
					}
				}
			}

			DisplayList();
		}

		//16
		public SingleLinkedList MergedSortedListsIntoNewList(SingleLinkedList list2)
		{
			SingleLinkedList mergedList = new SingleLinkedList();
			mergedList.start = MergeSortedListsToNewList(start, list2.start);
			return mergedList;
		}

		//16.1
		private Node MergeSortedListsToNewList(Node p1, Node p2)
		{
			Node pMStart;

			if (p1.info <= p2.info)
            {
				pMStart = new Node(p1.info);
				p1 = p1.link;
            }
            else
            {
				pMStart = new Node(p2.info);
				p2 = p2.link;
			}

			Node pM = pMStart;
			while (p1 != null && p2 != null)
			{
				if (p1.info < p2.info)
				{
					pM.link = new Node(p1.info);					 
					p1 = p1.link;
					pM = pM.link;
				}
				else
				{
					pM.link = new Node(p2.info);					
					p2 = p2.link;
					pM = pM.link;
				}
			}

			while (p1 != null)
			{
				pM.link = new Node(p1.info);				
				p1 = p1.link;
				pM = pM.link;
			}
			while (p2 != null)
			{
				pM.link = new Node(p2.info);				
				p2 = p2.link;
				pM = pM.link;
			}

			return pMStart;
		}

		//17
		public SingleLinkedList MergedSortedListsByReArrangingLinks(SingleLinkedList list4)
		{
			SingleLinkedList mergedList = new SingleLinkedList();
			mergedList.start = MergedSortedListsByReArrLinks(start, list4.start);
			return mergedList;
		}

		//17.1
		private Node MergedSortedListsByReArrLinks(Node p1, Node p2) 
		{
			Node pMStart;
			if(p1.info <= p2.info)
            {
				pMStart = p1;
				p1 = p1.link;

			}
            else
            {
				pMStart = p2;
				p2 = p2.link;
			}

			Node pM = pMStart;

            while (p1 != null && p2 != null)
            {
				if (p1.info <= p2.info)
				{
					pM.link = p1;
					p1 = p1.link;
					pM = pM.link;
				}
				else
				{
					pM.link = p2;
					p2 = p2.link;
					pM = pM.link;
				}
			}

			if (p1 != null)
				pM.link = p1;
			else if (p2 != null)
				pM.link = p2;

			return pMStart;

		}

		//18
		public void MergeSort() 
		{
			start = MergeSortRecursively(start);
		}

		//18.1
		private Node MergeSortRecursively(Node listStart)
        {
            if (listStart == null || listStart.link == null)
            {
				return listStart;
            }

			Node start1 = listStart;
			Node start2 = DivideListInHalf(listStart);

			start1 = MergeSortRecursively(start1);
			start2 = MergeSortRecursively(start2);

			Node pMStart = MergedSortedListsByReArrLinks(start1, start2);

			return pMStart;
		}

		private Node DivideListInHalf(Node p)
        {
			Node q = p.link.link;

            while (q != null && q.link != null)
            {
				p = p.link;
				q = q.link;
            }

			Node start2 = p.link;
			p.link = null;
			return start2;
        }

		public bool HasCycle() 
		{
			if (FindCycle() == null) {
				Console.WriteLine("The list does not have a cycle");
				return false;
            }
            else
            {
				Console.WriteLine("Cycle is found at Node: " + FindCycle().info);
				return true;
			}
		}

		private Node FindCycle()
        {
			if (start == null || start.link == null)
				return null;
			Node slowR = start, fastR = start;
            while (fastR != null && fastR.link != null)
            {
				slowR = slowR.link;
				fastR = fastR.link.link;

				if (slowR == fastR)
					return slowR;
            }

			return null;
        }

		public void InsertCycle(int x)
        {
			if (start == null)
            {
				Console.WriteLine("The list is empty");
				return;
			}

			Node p = start, px = null, prev = null;
            while (p != null)
            {
				if (p.info == x)
					px = p;
				prev = p;
				p = p.link;
            }

			if (px != null)
			{
				prev.link = px;
				Console.WriteLine("Cycle is inserted at node " + x);
			}
			else
				Console.WriteLine(x + " not found in the list. Cycle cannot be inserted");				
        }

		public void RemoveCycle()
        {
			Node c = FindCycle();
			if(c == null)
            {
				Console.WriteLine("Cycle not found in the list");
				return;
			}
				
			Console.WriteLine("Cycle is found at Node: " + FindCycle().info);

			Node p = c, q = c;
			int lenOfCycle = 0;
			do
			{
				lenOfCycle++;
				q = q.link;
			} while (p != q);

			Console.WriteLine("Length of cycle is: " + lenOfCycle);

			int lenOfRemList = 0;
			p = start;
            while (p != q)
            {
				lenOfRemList++;
				p = p.link;
				q = q.link;
            }

			Console.WriteLine("Length of remaining list is: " + lenOfRemList);

			int lenOfList = lenOfCycle + lenOfRemList;
			p = start;
            for (int i = 1; i <= lenOfList - 1; i++)
            {
				p = p.link;
            }

			p.link = null;

			Console.WriteLine("Cycle at node " + c.info + " is now removed");
		}

		public void ConcatenateLists(SingleLinkedList list2) 
		{
			if(start == null)
            {
				start = list2.start;
				return;
            }
			Node p = start;
            while (p.link != null)
            {
				p = p.link;
            }

			p.link = list2.start;

		}
	}
}
