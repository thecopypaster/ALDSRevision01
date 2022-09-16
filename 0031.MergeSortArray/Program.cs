// See https://aka.ms/new-console-template for more information

int choice;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Merge two sorted arrays into a new array.");
    Console.WriteLine("2. Merge two sorted portions of a single array");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (choice == 3)
        break;

    switch (choice)
    {
        case 1:
            int i, n1, n2;
            int[] a1 = new int[20];
            int[] a2 = new int[20];
            int[] temp = new int[40];
            Console.Write("Enter the number of elements in array a1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in sorted order: ");
            for (i = 0; i < n1; i++)
            {
                Console.Write("Enter the element " + (i + 1) + " : ");
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the number of elements in array a2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in sorted order: ");
            for (i = 0; i < n2; i++)
            {
                Console.Write("Enter the element " + (i + 1) + " : ");
                a2[i] = Convert.ToInt32(Console.ReadLine());
            }

            MergeSort(a1, a2, temp, n1, n2);
            Console.WriteLine("Merged array temp is: ");
            for (i = 0; i < (n1 + n2); i++)
                Console.Write(temp[i] + " ");
            Console.WriteLine();
            break;
        case 2:
            int j;
            int[] a = { 1, 3, 5, 7, 1, 4, 6, 9, 11, 14 };
            int[] temp2 = new int[20];

            MergeSortedPortionsOfArray(a, temp2, 0, 3, 4, 9);
            Console.WriteLine("The new sorted Array is: ");
            for (j = 0; j <= 9; j++)
                Console.Write(temp2[j] + " ");
            Console.WriteLine();
            break;
    }

    static void MergeSort(int[] a1, int[] a2, int[] temp, int n1, int n2)
    {
        int i = 0, j = 0, k = 0;
        while (i < n1 && j < n2)
        {
            if (a1[i] <= a2[j])
                temp[k++] = a1[i++];
            else
                temp[k++] = a2[j++];
        }

        while(i < n1)
            temp[k++] = a1[i++];
        while(j < n2)
            temp[k++] = a2[j++];
    }

    static void MergeSortedPortionsOfArray(int[] a, int[] temp2, int low1, int up1, int low2, int up2)
    {
        int i = low1, j = low2, k = low1;
        while (i <= up1 && j <= up2)
        {
            if (a[i] <= a[j])
                temp2[k++] = a[i++];
            else
                temp2[k++] = a[j++];
        }

        while(i <= up1)
            temp2[k++] = a[i++];
        while(j <= up2)
            temp2[k++] = a[j++];
    }
}
