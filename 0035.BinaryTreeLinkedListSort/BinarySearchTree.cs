using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0035.BinaryTreeLinkedListSort
{
    internal class BinarySearchTree
    {
        private TreeNode root;
        private int k;

        public BinarySearchTree()
        {
            root = null;
        }

        public void InsertRecursively(int x)
        {
            root = InsertRecursively(root, x);
        }

        public TreeNode InsertRecursively(TreeNode p, int x)
        {
            if (p == null)
                p = new TreeNode(x);
            else if (x < p.info)
                p.lchild = InsertRecursively(p.lchild, x);
            else if (x > p.info)
                p.rchild = InsertRecursively(p.rchild, x);
            else
                Console.WriteLine(x + "is already present in the tree");
            return p;
        }

        public void Inorder(int[] a)
        {
            k = 0;
            Inorder(root, a);
        }

        public void Inorder(TreeNode p, int[] a)
        {
            if (p == null)
                return;
            Inorder(p.lchild, a);
            a[k++] = p.info;
            Inorder(p.rchild, a);
        }
    }
}
