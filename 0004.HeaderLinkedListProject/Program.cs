// See https://aka.ms/new-console-template for more information
using _0004.HeaderLinkedListProject;

int choice, data, x, k;
HeaderLinkedList list = new HeaderLinkedList();
list.CreateList();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1.Display List");
    Console.WriteLine("2.Insert node at the end of the list");
    Console.WriteLine("3.Insert node before a Node");
    Console.WriteLine("4.Insert at a given position");
    Console.WriteLine("5.Delete node with value");
    Console.WriteLine("6.Reverse the list");
    Console.WriteLine("7.Quit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 7)
        break;

    switch (choice)
    {
        case 1:
            list.DisplayList();
            Console.WriteLine();
            break;
        case 2:
            Console.Write("Enter the node value to be inserted at the end: ");
            data = Convert.ToInt32(Console.ReadLine());
            list.InsertAtTheEnd(data);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 3:
            Console.Write("Enter the node value to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the node value before which the new node needs to be inserted: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeBeforeNode(data, x);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 4:
            Console.Write("Enter the node value to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the position for the new node needs to be inserted: ");
            k = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAtPosition(data, k);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 5:
            Console.Write("Enter the node value to be deleted: ");
            data = Convert.ToInt32(Console.ReadLine());
            list.DeleteNodeWithValue(data);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 6:
            list.ReverseList();
            Console.WriteLine();
            list.DisplayList();
            break;   
    }
}
