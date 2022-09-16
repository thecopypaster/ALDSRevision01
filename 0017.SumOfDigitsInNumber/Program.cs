// See https://aka.ms/new-console-template for more information

long n;
Console.Write("Enter a number: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of digits of the number " + n + " is: " + SumOfDigits(n));

static long SumOfDigits(long n) { 
    if(n / 10 == 0)
        return n;
    return SumOfDigits(n / 10) + (n % 10);
}

