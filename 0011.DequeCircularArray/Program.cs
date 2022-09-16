// See https://aka.ms/new-console-template for more information
using _0011.DequeCircularArray;

int x, k, choice;
Deque queueArray = new Deque(8);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Insert at front end");
    Console.WriteLine("2. Insert at rear end");
    Console.WriteLine("3. Delete from front end");
    Console.WriteLine("4. Delete from rear end");
    Console.WriteLine("5. Display all elements of the Queue");
    Console.WriteLine("6. Display size of the Queue");
    Console.WriteLine("7. Display first element of the Queue");
    Console.WriteLine("8. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 8)
        break;

    switch (choice)
    {
        case 1:
            Console.Write("Enter the element to insert at front end: ");
            x = Convert.ToInt32(Console.ReadLine());
            queueArray.InsertFront(x);
            Console.WriteLine();
            queueArray.Display();
            break;
        case 2:
            Console.Write("Enter the element to insert at rear end: ");
            x = Convert.ToInt32(Console.ReadLine());
            queueArray.InsertRear(x);
            Console.WriteLine();
            queueArray.Display();
            break;
        case 3:
            Console.Write("The deleted element from front end is: " + queueArray.DeleteFront());
            Console.WriteLine();
            break;
        case 4:
            Console.Write("The deleted element from front end is: " + queueArray.DeleteRear());
            Console.WriteLine();
            break;
        case 5:
            queueArray.Display();
            Console.WriteLine();
            break;
        case 6:
            Console.Write("The size of the Queue is: " + queueArray.Size());
            break;
        case 7:
            Console.Write("The first element in the Queue is: " + queueArray.Peek());
            break;
    }

}
