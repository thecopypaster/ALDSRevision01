// See https://aka.ms/new-console-template for more information

Node temp, p;
int i, n, data;
Console.WriteLine("Enter the number of elements in the list: ");
n = Convert.ToInt32(Console.ReadLine());
Node start = null;
for (i = 0; i <= n; i++)
{
    Console.Write("Enter the element " + i + " : ");
    data = Convert.ToInt32(Console.ReadLine());

    temp = new Node(data);
    if (start == null)
        start = temp;
    else
    {
        p = start;
        while (p.link != null)
            p = p.link;
        p.link = temp;
    }
}
start = RadixSort(start);
Console.WriteLine("Sorted list is: ");
p = start;
while (p != null)
{
    Console.Write(p.info + " ");
    p = p.link;
}
Console.WriteLine();

static Node RadixSort(Node start)
{
    Node[] rear = new Node[10];
    Node[] front = new Node[10];

    int leastSigniPos = 1;
    int mostSigniPos = DigitsInLargest(start);

    int i, dig;
    Node p;

    for (int k = leastSigniPos; k <= mostSigniPos; k++)
    {
        //Making all the queues empty at the beginning of each pass
        for (i = 0; i <= 9; i++)
        {
            rear[i] = null;
            front[i] = null;
        }

        for (p = start; p != null; p = p.link)
        {
            //Find kth digit from right in the number
            dig = Digit(p.info, k);

            //Insert the node in Queue(dig)
            if (front[dig] == null)
                front[dig] = p;
            else
                rear[dig].link = p;
            rear[dig] = p;
        }

        //Join all queues to form new linked list
        i = 0;
        while (front[i] == null)
            i++;
        start = front[i];
        while (i <= 8)
        {
            if (rear[i + 1] != null)   //If (i+1)th queue is not empty
                rear[i].link = front[i + 1];  //join end of ith queue to start
            else
                rear[i + 1] = rear[i];    //continue with rear[i]
            i++;
        }
        rear[9].link = null;
    }
    return start;
}   //End of sort

static int DigitsInLargest(Node start)
{
    //Find largest element
    int large = 0;
    Node p = start;
    while (p != null)
    {
        if (p.info > large)
            large = p.info;
        p = p.link;
    }

    //Find number of digits in largest element
    int ndigits = 0;
    while (large != 0)
    {
        ndigits++;
        large /= 10;
    }

    return ndigits;
}

//Returns kth digit from right in n
static int Digit(int n, int k)
{
    int d = 0, i;
    for (i = 1; i <= k; i++)
    {
        d = n % 10;
        n /= 10;
    }
    return d;
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