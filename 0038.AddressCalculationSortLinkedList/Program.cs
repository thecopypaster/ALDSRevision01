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

AddressCalculationSort(a, n);
Console.WriteLine("Sorted array is: ");
for (i = 0; i < n; i++)
    Console.Write(a[i] + " ");
Console.WriteLine();

static void AddressCalculationSort(int[] a, int n)
{
    int i, j, x;

    SortedLinkedList[] linkedList = new SortedLinkedList[6];
    for (i = 0; i < 6; i++)
        linkedList[i] = new SortedLinkedList();

    int large = 0;
    for (i = 0; i < n; i++)
    {
        if (a[i] > large)
            large = a[i];
    }

    for (i = 0; i < n; i++)
    {
        x = Hash(a[i], large);
        linkedList[x].InsertInOrder(a[i]);
    }

    //ELements of linked lists are copied to array
    Node p;
    i = 0;
    for (j = 0; j <= 5; j++)
    {
        p = linkedList[j].GetStart();
        while (p != null)
        {
            a[i++] = p.info;
            p = p.link;
        }
    }
}

static int Hash(int x, int large)
{
    float temp;
    temp = (float)x / large;
    return (int)(temp * 5);
}
class Node
{
    public int info;
    public Node link;

    public Node(int i)
    {
        info = i;
        link = null;
    }
}

internal class SortedLinkedList
{
    private Node start;
    //Initialize start to NULL for everything else in the program to work.
    public SortedLinkedList() 
    {
        start = null;
    }

    public void InsertInOrder(int data)
    {
        Node p, temp;
        temp = new Node(data);

        //List empty or new node to be inserted before first node
        if (start == null || data < start.info)
        {
            temp.link = start;
            start = temp;
            return;
        }

        p = start;
        while (p.link != null && p.link.info <= data)
            p = p.link;
        temp.link = p.link;
        p.link = temp;
    }

    public Node GetStart()
    {
        return start;
    }
}
