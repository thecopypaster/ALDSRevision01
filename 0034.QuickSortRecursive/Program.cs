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
QuickSort(a, n);
Console.WriteLine("Sorted array is: ");
for (i = 0; i < n; i++)
    Console.Write(a[i] + " ");
Console.WriteLine();

static void QuickSort(int[] a, int n)
{
    Sort(a, 0, n-1);    
}

static void Sort(int[] a, int low, int up)
{
    if (low >= up)
        return;
    int p = Partition(a, low, up);
    Sort(a, low, p-1);
    Sort(a, p+1, up);
}

static int Partition(int[] a, int low, int up)
{
    int temp, i, j, pivot;
    pivot = a[low];
    i = low + 1;
    j = up;
    while (i <= j)
    {
        while (a[i] < pivot && i < up)
            i++;
        while (a[j] > pivot)
            j--;
        if (i < j)
        {
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            i++;
            j++;
        }
        else
            break;
    }
    a[low] = a[j];
    a[j] = pivot;
    return j;
}
