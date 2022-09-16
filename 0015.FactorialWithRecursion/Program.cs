// See https://aka.ms/new-console-template for more information

int n;
Console.Write("Enter a number greater than or equal to zero: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial of " + n + " is: " + Factorial(n));

static long Factorial(int n)
{
    if (n == 0)
        return 1;
    return n * Factorial(n - 1);
}