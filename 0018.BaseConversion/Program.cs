// See https://aka.ms/new-console-template for more information

int n;
Console.Write("Enter a positive decimal number: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Binary Form: ");
ToBinary(n);
Console.WriteLine();

Console.Write("Binary Form: ");
ConvertBase(n, 2);
Console.WriteLine();

Console.Write("Octal Form: ");
ConvertBase(n, 8);
Console.WriteLine();

Console.Write("Hexadecimal Form: ");
ConvertBase(n, 16);
Console.WriteLine();


static void ToBinary(int n)
{
    if(n == 0)
        return;
    ToBinary(n/2);
    Console.Write(n%2);
}

static void ConvertBase(int n, int b)
{
    if (n == 0)
        return;
    ConvertBase(n/b, b);
    int remainder = n % b;
    if(remainder < 10)
        Console.Write(remainder);
    else
        Console.Write((char)(remainder - 10 + 'A'));

}
