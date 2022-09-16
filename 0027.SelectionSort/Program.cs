// See https://aka.ms/new-console-template for more information

int[] a = {6, 12, 21, 3, 17, 24 };
int n = 6;
SelectionSort(a, n);
Console.Write("The sorted array is: ");
for (int i = 0; i < n; i++)
{
    Console.Write(a[i] + "  ");
}
Console.WriteLine();
static void SelectionSort(int[] a, int n)
{
    int minIndex, temp;
    for (int i = 0; i < n-1; i++)
    {
        minIndex = i;
        for (int j = i+1; j < n; j++)
        {
            if (a[j] < a[minIndex])
                minIndex = j;
        }
        if(i != minIndex)
        {
            temp = a[i];
            a[i] = a[minIndex];
            a[minIndex] = temp;
        }
    }
}
