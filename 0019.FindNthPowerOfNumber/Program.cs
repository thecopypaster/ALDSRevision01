// See https://aka.ms/new-console-template for more information

int n;
double x;
Console.Write("Enter the value of x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter the power to be calculated for x: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x + " power " + n + " is: " + FindNthPowerOfX(x, n));

static double FindNthPowerOfX(double x, int n)
{
    if (n == 0)
        return 1;
    return x * FindNthPowerOfX(x, n - 1);
}
