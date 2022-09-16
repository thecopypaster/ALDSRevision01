// See https://aka.ms/new-console-template for more information
int[] a = { 6, 12, 21, 3, 17, 24 };
int n = 6;
BubbleSortWithSwaps(a, n);
Console.Write("The sorted array is: ");
for (int i = 0; i < n; i++)
{
    Console.Write(a[i] + "  ");
}
Console.WriteLine();

static void BubbleSortWithSwaps(int[] a, int n)
{
    int temp, swaps;
    for (int i = n-2; i >= 0; i--)
    {
        swaps = 0;
        for(int j = 0; j <= i; j++)
        {
            if (a[j] > a[j + 1])
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
                swaps++;
            }
        }
        if (swaps == 0)
            break;
    }
}
