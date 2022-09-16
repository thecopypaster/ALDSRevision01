// See https://aka.ms/new-console-template for more information
int n;
Console.Write("Enter the number of disks: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("The path to move " + n + " disks from A => C is: ");
Hanoi(n, 'A', 'B', 'C');


static void Hanoi(int n, char source, char temp, char dest)
{
    if (n == 1)
    {
        Console.WriteLine("Move disk " + n + " from " + source + " ==> " + dest);
        return;
    }
    Console.WriteLine();
    Hanoi(n-1, source, dest, temp);
    Console.WriteLine("Move disk " + n + " from " + source + " ==> " + dest);
    Hanoi(n-1, temp, source, dest);
}
