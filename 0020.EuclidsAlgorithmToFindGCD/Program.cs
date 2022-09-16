// See https://aka.ms/new-console-template for more information
int a, b;
Console.WriteLine("Enter values of a & b to find their GCD: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("GCD of " + a + " and " + b + " is: " + GCD(a, b));

static int GCD(int a, int b)
{
    if(b == 0)
        return a;
    return GCD(b, a%b);
}
