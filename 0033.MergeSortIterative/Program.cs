// See https://aka.ms/new-console-template for more information
int i, n;
int[] a = new int[20];
Console.Write("Enter the number of elements: ");
n = Convert.ToInt32(Console.ReadLine());
for (i = 0; i < n; i++)
{
    Console.Write("Enter the element " + (i + 1) + " : ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
MergeSortIterative(a, n);
Console.WriteLine("Sorted array is: ");
for (i = 0; i < n; i++)
    Console.Write(a[i] + " ");
Console.WriteLine();

static void MergeSortIterative(int[] a, int n)
{
    int[] temp = new int[n];
    int size = 1;
    while (size <= n-1)
    {
        SortPass(a, temp, size, n);
        size = size * 2;
    }
}

static void SortPass(int[] a, int[] temp, int size, int n)
{
    int i, low1, low2, up1, up2;
    low1 = 0;
    while (low1 + size <= n-1)
    {
        up1 = low1 + size - 1;
        low2 = low1 + size;
        up2 = low2 + size - 1;

        if (up2 >= n)
            up2 = n - 1;

        Merge(a, temp, low1, up1, low2, up2);
        low1 = up2 + 1;
    }
    for (i = low1; i <= n - 1; i++)
        temp[i] = a[i];

    Copy(a, temp, n);
}

static void Merge(int[] a, int[] temp, int low1, int up1, int low2, int up2)
{
    int i = low1, j = low2, k = low1;
    while ((i <= up1) && (j <= up2))
    {
        if (a[i] <= a[j])
            temp[k++] = a[i++];
        else
            temp[k++] = a[j++];
    }
    while (i <= up1)
        temp[k++] = a[i++];
    while (j <= up2)
        temp[k++] = a[j++];
}

static void Copy(int[] a, int[] temp, int n)
{
    for (int i = 0; i < n; i++)
        a[i] = temp[i];
}


