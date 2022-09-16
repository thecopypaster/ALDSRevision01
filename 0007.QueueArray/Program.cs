// See https://aka.ms/new-console-template for more information
using _0007.QueueArray;

int x, k, choice;
QueueA queueA = new QueueA();
queueA.CreateQueue();
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Insert an element on to the Queue");
    Console.WriteLine("2. Delete an element from the Queue");
    Console.WriteLine("3. Display elements in Queue");    
    Console.WriteLine("4. Display size of the Queue");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 5)
        break;

    switch (choice)
    {
        case 1:
            Console.Write("Enter the element to be pushed into Queue: ");
            x = Convert.ToInt32(Console.ReadLine());
            queueA.Enqueue(x);
            Console.WriteLine();
            queueA.Display();
            break;
        case 2:
            Console.Write("The dequeued element is: " + queueA.Dequeue());
            Console.WriteLine();
            break;
        case 3:
            queueA.Display();
            Console.WriteLine();
            break;       
        case 4:
            Console.Write("The size of the Queue is: " + queueA.Size());
            break;
    }

}

