// See https://aka.ms/new-console-template for more information
using _0005.StackArrayProject;

int x, k, choice;
StackA stack = new StackA();
Console.Write("Enter the number of elements to be pushed on the stack: ");
k = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= k; i++)
{
    Console.Write("Enter element " + i + " : ");
    x = Convert.ToInt32(Console.ReadLine());
    stack.Push(x);
}

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Push an element on to the stack");
    Console.WriteLine("2. Pop an element from the stack");
    Console.WriteLine("3. Display elements in stack");
    Console.WriteLine("4. Display the top element");
    Console.WriteLine("5. Display size of the stack");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 6)
        break;

    switch (choice)
    {
        case 1:           
            Console.Write("Enter the element to be pushed on stack: ");
            x = Convert.ToInt32(Console.ReadLine());
            stack.Push(x);
            Console.WriteLine();
            stack.Display();
            break;
        case 2:       
            Console.Write("The popped top element is: " + stack.Pop());
            Console.WriteLine();            
            break;
        case 3:
            stack.Display();
            Console.WriteLine();
            break;
        case 4:            
            Console.Write("The top element in the stack is: " + stack.Peek());
            break;
        case 5:
            Console.Write("The size of the stack is: " + stack.Size());
            break;
    }

}
