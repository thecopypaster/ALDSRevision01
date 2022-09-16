// See https://aka.ms/new-console-template for more information

int n, choice;
while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Display numbers from 1 to n");
    Console.WriteLine("2. Display numbers from n to 1");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());    

    switch (choice)
    {
        case 1:
            Console.Write("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Display1ToN(n);
            break;
        case 2:
            Console.Write("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            DisplayNTo1(n);
            break;
    }
}

static void Display1ToN(int n)
{
    if (n == 0)
        return;
    Display1ToN(n - 1);
    Console.Write(n + " ");
}

static void DisplayNTo1(int n)
{
    if (n == 0)
        return;
    Console.Write(n + " ");
    DisplayNTo1(n - 1);    
}
