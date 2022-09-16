// See https://aka.ms/new-console-template for more information
using _0025.HeapArray;

Heap h = new Heap(20);

int choice, value;

while (true)
{
    Console.WriteLine("1. Insert");
    Console.WriteLine("2. Delete Root");
    Console.WriteLine("3. Display");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 4)
        break;

    switch (choice)
    {
        case 1:
            Console.Write("Enter the value to be inserted: ");
            value = Convert.ToInt32(Console.ReadLine());
            h.Insert(value);
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Maximum value is " + h.DeleteRoot());
            Console.WriteLine();
            break;
        case 3:
            h.Display();
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Wrong choice");
            break;
    }
}
