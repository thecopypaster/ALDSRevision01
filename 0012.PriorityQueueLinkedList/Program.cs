// See https://aka.ms/new-console-template for more information
using _0012.PriorityQueueLinkedList;

int x, k, choice;
PriorityQueueLL pQueue = new PriorityQueueLL();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Insert a new element");  
    Console.WriteLine("2. Delete an element");    
    Console.WriteLine("3. Display the Queue");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 4)
        break;

    switch (choice)
    {
        case 1:
            Console.Write("Enter the element to insert in the Priority Queue: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the priority of the element: ");
            k = Convert.ToInt32(Console.ReadLine());
            pQueue.Insert(x, k);
            Console.WriteLine();
            pQueue.Display();
            break;
        case 2:
            Console.Write("Deleted element from the priority queue is " + pQueue.Delete());           
            Console.WriteLine();            
            break;       
        case 5:
            pQueue.Display();
            Console.WriteLine();
            break;        
    }

}

