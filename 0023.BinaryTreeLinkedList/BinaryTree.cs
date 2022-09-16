using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023.BinaryTreeLinkedList
{
    internal class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void CreateTree()
        {
            root = new Node('P');
            root.lchild = new Node('Q');
            root.rchild = new Node('R');
            root.lchild.lchild = new Node('A');
            root.lchild.rchild = new Node('B');
            root.rchild.lchild = new Node('X');            
        }

        public void DisplayTree()
        {            
            Display(root, 0);
        }

        public void Display(Node p, int level)
        {
            if (p == null)
            {
                return;
            }

            Display(p.rchild, level+1);
            Console.WriteLine();
            for (int i = 0; i < level; i++)
                Console.Write("  ");
            Console.Write(p.info + " ");
            Display(p.lchild, level+1);

        }

        public void PreOrder()
        {
            PreOrder(root);
        }

        public void PreOrder(Node p)
        {
            if (p == null)
                return;
            Console.Write(p.info + " ");
            PreOrder(p.lchild);            
            PreOrder(p.rchild);
        }

        public void InOrder()
        {
            InOrder(root);
        }

        public void InOrder(Node p)
        {
            if (p == null)
                return;
            InOrder(p.lchild);
            Console.Write(p.info + " ");
            InOrder(p.rchild);

        }

        public void PostOrder() 
        {
            PostOrder(root);
        }

        public void PostOrder(Node p)
        {
            if (p == null)
                return;

            PostOrder(p.lchild);
            PostOrder(p.rchild);
            Console.Write(p.info + " ");
        }      

        public void LevelOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }                

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node p;
            while (queue.Count > 0)
            {
                p = queue.Dequeue();
                Console.Write(p.info + " ");
                if(p.lchild != null)
                    queue.Enqueue(p.lchild);
                if(p.rchild != null)
                    queue.Enqueue(p.rchild);
            }

            Console.WriteLine();
        }

        public int Height()
        {
            return Height(root);
        }

        public int Height(Node p)
        {
            if (p == null)
                return 0;

            int hL = Height(p.lchild);
            int hR = Height(p.rchild);

            if (hL > hR)
                return 1 + hL;
            else
                return 1 + hR;
        }
    }
}
