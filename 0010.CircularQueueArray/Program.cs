// See https://aka.ms/new-console-template for more information
using _0010.CircularQueueArray;

int n, x, k, choice;
CircularQueue queue = new CircularQueue();
Console.Write("Enter number of elements in the Linked List: ");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write("Enter the element at " + i + " : ");
    x = Convert.ToInt32(Console.ReadLine());
    queue.Insert(x);
}
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Insert an element into the Queue");
    Console.WriteLine("2. Delete an element from the Queue");
    Console.WriteLine("3. Display elements in the Queue");
    Console.WriteLine("4. Display size of the Queue");
    Console.WriteLine("5. Display First element of the Queue");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 6)
        break;

    switch (choice)
    {
        case 1:
            Console.Write("Enter the element to be pushed into the Queue: ");
            x = Convert.ToInt32(Console.ReadLine());
            queue.Insert(x);
            Console.WriteLine();
            queue.Display();
            break;
        case 2:
            Console.Write("The deleted element is: " + queue.Delete());
            Console.WriteLine();
            break;
        case 3:
            queue.Display();
            Console.WriteLine();
            break;
        case 4:
            Console.Write("The size of the Queue is: " + queue.Size());
            break;
        case 5:
            Console.Write("The first element in the Queue is: " + queue.Peek());
            break;
    }

}
