// See https://aka.ms/new-console-template for more information
using _0001.SingleLinkedList;

int x, i, choice;
SingleLinkedList list = new SingleLinkedList();

while (true)
{
    Console.WriteLine("1. Create a Linked List");
    Console.WriteLine("2. Display linked list");
    Console.WriteLine("3. Display linked list count");
    Console.WriteLine("4. Insert a node at the end");
    Console.WriteLine("5. Insert a node at the beginning");
    Console.WriteLine("6. Insert a node after Node with certain value");
    Console.WriteLine("7. Insert a node before a Node with certain value");
    Console.WriteLine("8. Insert a node at a position in the list");
    Console.WriteLine("9. Search node and list position");
    Console.WriteLine("10. Delete node with value");
    Console.WriteLine("11. Delete last node");
    Console.WriteLine("12. Delete first node");
    Console.WriteLine("13. Reverse Linked List");
    Console.WriteLine("14. Bubble Sort Usig Link Exchange");
    Console.WriteLine("15. Bubble Sort Usig Data Exchange");
    Console.WriteLine("16. Merge sorted lists using new list");
    Console.WriteLine("17. Merge sorted lists by rearranging links");
    Console.WriteLine("18. Merge Sort Algorithm");
    Console.WriteLine("19. insert a cycle in the list");
    Console.WriteLine("20. Check if List has a Cycle");
    Console.WriteLine("21. Remove cycle from List");
    Console.WriteLine("22. Concatenate Lists");
    Console.WriteLine("100. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 100)
        break;

    switch (choice)
    {
        case 1:
            list.CreateLinkedList();
            Console.WriteLine();
            break;
        case 2:
            list.DisplayList();
            break;
        case 3:
            list.Count();
            break;
        case 4:
            Console.Write("Enter the element to be inserted at the end: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAtEnd(x);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 5:
            Console.Write("Enter the element to be inserted at the beginning: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAtTheBeginning(x);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 6:
            Console.Write("Enter the element to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the element after which new node needs to be inserted: ");
            i = Convert.ToInt32(Console.ReadLine());
            list.InsertAfterNode(x, i);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 7:
            Console.Write("Enter the element to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the element before which new node needs to be inserted: ");
            i = Convert.ToInt32(Console.ReadLine());
            list.InsertBeforeNode(x, i);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 8:
            Console.Write("Enter the element to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the position at which the new node needs to be inserted: ");
            i = Convert.ToInt32(Console.ReadLine());
            list.InsertAtPosition(x, i);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 9:
            Console.Write("Enter the element to search: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.SearchNodeAndListPosition(x);
            Console.WriteLine();
            break;
        case 10:
            Console.Write("Enter the node value to delete: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.DeleteNodeWithValue(x);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 11:
            list.DeleteLastNode();
            list.DisplayList();
            Console.WriteLine();
            break;
        case 12:
            list.DeleteFirstNode();
            list.DisplayList();
            Console.WriteLine();
            break;
        case 13:
            list.ReverseLinkedList();
            Console.WriteLine();
            break;
        case 14:
            list.BubbleSortUsingLinkExchange();
            Console.WriteLine();
            break;
        case 15:
            list.BubbleSortUsingDataExchange();
            Console.WriteLine();
            break;
        case 16:
            SingleLinkedList list1 = new SingleLinkedList();
            list1.CreateLinkedList();
            Console.WriteLine();
            list1.BubbleSortUsingDataExchange();
            Console.WriteLine();
            SingleLinkedList list2 = new SingleLinkedList();
            list2.CreateLinkedList();
            Console.WriteLine();
            list2.BubbleSortUsingDataExchange();
            Console.WriteLine();

            SingleLinkedList list3 = list1.MergedSortedListsIntoNewList(list2);
            Console.WriteLine();
            Console.Write("New merged list is: ");
            list3.DisplayList();
            Console.WriteLine();
            break;
        case 17:
            SingleLinkedList list4 = new SingleLinkedList();
            list4.CreateLinkedList();
            Console.WriteLine();
            list4.BubbleSortUsingDataExchange();
            Console.WriteLine();
            SingleLinkedList list5 = new SingleLinkedList();
            list5.CreateLinkedList();
            Console.WriteLine();
            list5.BubbleSortUsingDataExchange();
            Console.WriteLine();

            SingleLinkedList list6 = list4.MergedSortedListsByReArrangingLinks(list5);
            Console.WriteLine();
            Console.Write("New merged list is: ");
            list6.DisplayList();
            Console.WriteLine();
            break;
        case 18:
            SingleLinkedList list7 = new SingleLinkedList();
            list7.CreateLinkedList();
            Console.WriteLine();
            list7.MergeSort();
            Console.WriteLine();
            Console.Write("New merged list is: ");
            list7.DisplayList();
            Console.WriteLine();
            break;
        case 19:
            Console.WriteLine("Enter the node at which cycle needs to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.InsertCycle(x);
            Console.WriteLine();
            break;
        case 20:
            list.HasCycle();
            Console.WriteLine();
            break;
        case 21:
            list.RemoveCycle();
            Console.WriteLine();
            break;
        case 22:
            SingleLinkedList list8 = new SingleLinkedList();
            list8.CreateLinkedList();
            Console.WriteLine();
            list.ConcatenateLists(list8);
            Console.WriteLine();
            Console.Write("New concatenated list is: ");
            list.DisplayList();
            Console.WriteLine();
            break;

    }

}
