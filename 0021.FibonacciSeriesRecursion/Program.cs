// See https://aka.ms/new-console-template for more information

int n;
Console.Write("Enter the number of terms: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("The fibonacci series for " + n + " terms is: ");
for (int i = 0; i <= n; i++)
{
    Console.Write(Fib(i) + " ");       
}

Console.WriteLine();
Console.WriteLine("The fibonacci number at " + n + " is: " + Fib(n));

static int Fib(int n)
{
    if(n == 0)
        return 0;
    if(n == 1)
        return 1;
    return Fib(n - 1) + Fib(n-2);
}
