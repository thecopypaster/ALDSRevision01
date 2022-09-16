// See https://aka.ms/new-console-template for more information
using _0023.BinaryTreeLinkedList;

BinaryTree tree = new BinaryTree();

tree.CreateTree();
Console.WriteLine();

Console.WriteLine("Display binary tree: ");
tree.DisplayTree();
Console.WriteLine();

Console.WriteLine("Preorder travel is: ");
tree.PreOrder();
Console.WriteLine();

Console.WriteLine("Inorder traversal is: ");
tree.InOrder();
Console.WriteLine();

Console.WriteLine("Postorder traversal is: ");
tree.PostOrder();
Console.WriteLine();

Console.WriteLine("Height of binary tree is: " + tree.Height());
Console.WriteLine();

