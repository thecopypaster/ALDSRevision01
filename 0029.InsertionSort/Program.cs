// See https://aka.ms/new-console-template for more information

int[] a1 = { 21, 34, 23, 2, 5, 6, 11, 25 };
int n1 = 8;
InsertionSortAscending(a1, n1);
Console.Write("The array in ascending order is: ");
for (int i = 0; i < n1; i++)
{
	Console.Write(a1[i] + "  ");
}
Console.WriteLine();
int[] a2 = { 21, 34, 23, 2, 5, 6, 11, 25 };
int n2 = 8;
InsertionSortDescending(a2, n2);
Console.Write("The array in descending order is: ");
for (int i = 0; i < n2; i++)
{
	Console.Write(a2[i] + "  ");
}
Console.WriteLine();

static void InsertionSortAscending(int[] a, int n)
{
	int i, j, temp;
    for (i = 1; i < n; i++)
    {
        temp = a[i];
        for (j = i-1; j >= 0 && a[j] > temp; j--)
            a[j+1] = a[j];
        a[j + 1] = temp;
    }
}

static void InsertionSortDescending(int[] a, int n)
{
    int i, j, temp;
    for (i = 1; i < n; i++)
    {
        temp = a[i];
        for (j = i - 1; j >= 0 && a[j] < temp; j--)
            a[j + 1] = a[j];
        a[j + 1] = temp;
    }
}
