// See https://aka.ms/new-console-template for more information
using _0002.DoubleLinkedList;

int choice, x, k;
DoubleLinkedList list = new DoubleLinkedList();
list.CreateList();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Display List");
    Console.WriteLine("2.Count the number of nodes");
    Console.WriteLine("3.Search for an element & list its position.");
    Console.WriteLine("4.Insert node at the end");
    Console.WriteLine("5.Insert node at the beginning");
    Console.WriteLine("6.Insert node after Node");
    Console.WriteLine("7.Insert node before node");
    Console.WriteLine("8.Delete node at the end");
    Console.WriteLine("9.Delete node at the beginning");
    Console.WriteLine("10.Reverse the linked list");
    Console.WriteLine("11.Delete node with value");
    Console.WriteLine("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 100)
        break;

    switch (choice)
    {
        case 1:
            list.DisplayList();
            Console.WriteLine();
            break;
        case 2:
            list.Count();
            Console.WriteLine();
            break;
        case 3:
            Console.Write("Enter the node value to be searched: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.Search(x);
            Console.WriteLine();
            break;
        case 4:
            Console.Write("Enter the node value to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAtEnd(x);
            Console.WriteLine();
            list.DisplayList();
            break;
        case 5:
            Console.Write("Enter the node value to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAtBeginning(x);
            Console.WriteLine();
            list.DisplayList();
            break;
        case 6:
            Console.Write("Enter the new node value to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the node value after which new node needs to be inserted: ");
            k = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAfterNode(x, k);
            Console.WriteLine();
            list.DisplayList();
            break;
        case 7:
            Console.Write("Enter the new node value to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the node value before which new node needs to be inserted: ");
            k = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeBeforeNode(x, k);
            Console.WriteLine();
            list.DisplayList();
            break;
        case 8:
            list.DeleteNodeAtEnd();
            Console.WriteLine();
            list.DisplayList();
            break;
        case 9:
            list.DeleteNodeAtBeginning();
            Console.WriteLine();
            list.DisplayList();
            break;
        case 10:
            list.ReverseLinkedList();
            Console.WriteLine();
            list.DisplayList();
            break;
        case 11:
            Console.Write("Enter the new node value to be deleted: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.DeleteNodeWithValue(x);
            Console.WriteLine();
            list.DisplayList();
            break;
    }
}
