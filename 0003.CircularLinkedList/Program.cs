// See https://aka.ms/new-console-template for more information

using _0003.CircularLinkedList;

int choice, data, positionNode, nodeValue;
CircularLinkedList list = new CircularLinkedList();
list.CreateLinkedList();
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1.Display List");   
    Console.WriteLine("2.Insert node at the end");
    Console.WriteLine("3.Insert node at the beginning");
    Console.WriteLine("4.Insert node after Node");
    Console.WriteLine("5.Delete node with value");
    Console.WriteLine("6.Delete node at the end");
    Console.WriteLine("7.Delete node at the beginning");
    Console.WriteLine("8.Concatenate lists");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            list.DisplayList();
            Console.WriteLine();
            break;       
        case 2:
            Console.WriteLine("Enter the node value to be inserted at the end: ");
            data = Convert.ToInt32(Console.ReadLine());
            list.InsertAtTheEnd(data);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Enter the node value to be inserted at the beginning: ");
            data = Convert.ToInt32(Console.ReadLine());
            list.InsertInTheBeginning(data);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("Enter the value to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the after node: ");
            nodeValue = Convert.ToInt32(Console.ReadLine());
            list.InsertNodeAfterNode(data, nodeValue);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("Enter the node value to be deleted: ");
            data = Convert.ToInt32(Console.ReadLine());
            list.DeleteNodeWithValue(data);
            list.DisplayList();
            Console.WriteLine();
            break;
        case 6:
            list.DeleteNodeAtTheEnd();
            list.DisplayList();
            Console.WriteLine();
            break;
        case 7:
            list.DeleteNodeAtTheBeginning();
            list.DisplayList();
            Console.WriteLine();
            break;
        case 8:
            CircularLinkedList list2 = new CircularLinkedList();
            list2.CreateLinkedList();
            list.ConcatenateLists(list2);
            list.DisplayList();
            Console.WriteLine();
            break;        
    }
}
