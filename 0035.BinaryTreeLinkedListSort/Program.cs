// See https://aka.ms/new-console-template for more information
using _0035.BinaryTreeLinkedListSort;

int i, n;
int[] a = new int[20];

Console.Write("Enter the number of elements: ");
n = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.Write("Enter the element " + (i + 1) + " : ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}

BinaryTreeSort(a, n);
Console.WriteLine("Sorted array is: ");
for (i = 0; i < n; i++)
    Console.Write(a[i] + " ");
Console.WriteLine();

static void BinaryTreeSort(int[] a, int n)
{
    BinarySearchTree tree = new BinarySearchTree();   
    for (int i = 0; i < n; i++)
        tree.InsertRecursively(a[i]);    
    tree.Inorder(a);
}


