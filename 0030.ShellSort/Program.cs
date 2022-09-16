// See https://aka.ms/new-console-template for more information

int i, n;
int[] a = new int[20];

Console.Write("Enter the number of elements: ");
n = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.Write("Enter element " + (i + 1) + " : ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}

ShellSort(a, n);

Console.Write("The sorted array in ascending order is: ");
for (i = 0; i < n; i++)
    Console.Write(a[i] + " ");
Console.WriteLine();

Console.Write("The sorted array in descending order is: ");
for (i = n-1; i >=0; i--)
    Console.Write(a[i] + " ");
Console.WriteLine();

static void ShellSort(int[] a, int n)
{
    int i, h, j, temp;
    Console.Write("Enter a maximum increment value that is an odd number: ");
    h = Convert.ToInt32(Console.ReadLine());

    while (h >= 1)
    {
        for (i = h; i < n; i++)
        {
            temp = a[i];
            for (j = i-h; j >= 0 && a[j] > temp; j = j-h)
                a[j+h] = a[j];
            a[j + h] = temp;
        }
        h = h - 2;
    }
}