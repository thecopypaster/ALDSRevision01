// See https://aka.ms/new-console-template for more information

int[] a1 = { 99999, 1, 4, 5, 7, 9, 10 };
int n1 = a1.Length - 1;
TopDown(a1, n1);
for (int i = 1; i <= n1; i++)
    Console.Write(a1[i] + "  ");
Console.WriteLine();



int[] a2 = { 99999, 1, 4, 5, 7, 9, 10 };
int n2 = a2.Length - 1;
BottomUp(a2, n2);
for (int i = 1; i <= n2; i++)
    Console.Write(a2[i] + "  ");
Console.WriteLine();


static void TopDown(int[] a, int n)
{
    for (int i = 2; i <= n; i++)
        RestoreUp(a, i);        
}

static void RestoreUp(int[] a, int i)
{
    int k = a[i];
    int iParent = i / 2;
    while (a[iParent] < k)
    {
        a[i] = a[iParent];
        i = iParent;
        iParent = i / 2;
    }

    a[i] = k;
}

static void BottomUp(int[] a, int n)
{
    for (int i = n / 2; i >= 1; i--)
        RestoreDown(a, i, n);
}

static void RestoreDown(int[] a, int i, int n)
{
    int k = a[i];
    int lchild = 2 * i;
    int rchild = lchild + 1;

    while (rchild <= n)
    {
        if(k >= a[lchild] && k >= a[rchild])
        {
            a[i] = k;
            return;
        }
        else if (a[lchild] > a[rchild])
        {
            a[i] = a[lchild];
            i = lchild;
        }
        else
        {
            a[i] = a[rchild];
            i = rchild;
        }

        lchild = 2 * i;
        rchild = lchild + 1;
    }

    if(n == lchild && k < a[lchild])
    {
        a[i] = a[lchild];
        i = lchild;
    }

    a[i] = k;
}
