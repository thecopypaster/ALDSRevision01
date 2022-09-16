using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0024.BinarySearchTreeLinkedList
{
    internal class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Display()
        {
            Display(root, 0);
        }

        public void Display(Node p, int level)
        {
            if (p == null)
                return;
            
            Display(p.rchild, level + 1);
            Console.WriteLine();
            for (int i = 0; i < level; i++)
                Console.Write("  ");
            Console.Write(p.info + " ");
            Display(p.lchild, level + 1);
            Console.WriteLine();
        }

        public void Insert(int x)
        {
            Node p = root;
            Node parent = null;

            while (p != null)
            {
                parent = p;
                if (x < p.info)
                    p = p.lchild;
                else if (x > p.info)
                    p = p.rchild;
                else
                {
                    Console.WriteLine("Node " + x + " already exists. Cannot insert.");
                    return;
                }
            }

            Node temp = new Node(x);
            if(parent == null)
                root = temp;
            else if(x < parent.info)
                parent.lchild = temp;
            else
                parent.rchild = temp;
        }

        public void InsertRecursively(int x)
        {            
          root = InsertRecursively(root, x);
        }

        public Node InsertRecursively(Node p, int x)
        {
            if (p == null)
                p = new Node(x);
            else if (x < p.info)
                p.lchild = InsertRecursively(p.lchild, x);
            else if (x > p.info)
                p.rchild = InsertRecursively(p.rchild, x);
            else
                Console.WriteLine(x + " is already present in the tree");

            return p;
        }

        public void Delete(int x)
        {
            Node p = root;
            Node parent = null;

            //Find node with x value
            while (p != null)
            {
                if (x == p.info)
                    break;
                parent = p;
                if (x < p.info)
                    p = p.lchild;
                else if (x > p.info)
                    p = p.rchild;                
            }

            if(p == null)
            {
                Console.WriteLine(x + " is not found in the tree");
                return;
            }

            //Once the node with X value is found, check to see if this node has, no, 1 or 2 children
            Node successor, pSuccessor;
            //Checking if p has two children
            if(p.lchild != null && p.rchild != null)
            {
                pSuccessor = p;
                successor = p.rchild;

                while (successor.lchild != null)
                {
                    pSuccessor = successor;
                    successor = successor.lchild;
                }

                p.info = successor.info;
                p = successor;
                parent = pSuccessor;
            }

            //checking if p has only one children
            Node ch;
            if (p.lchild != null)
                ch = p.lchild;
            else
                ch = p.rchild;

            if (parent == null)
                root = ch;
            else if (p == parent.lchild)
                parent.lchild = ch;
            else
                parent.rchild = ch;
        }

        public void DeleteRecursively(int x)
        {
            root = DeleteRecursively(root, x);
        }

        public Node DeleteRecursively(Node p, int x)
        {
           Node ch, successor;
           if(p == null)
            {
                Console.WriteLine(x + " not found");
                return p;
            }

            if (x < p.info)
                p.lchild = DeleteRecursively(p.lchild, x);
            else if (x > p.info)
                p.rchild = DeleteRecursively(p.rchild, x);
            else
            {
                if(p.lchild != null && p.rchild != null)
                {
                    successor = p.rchild;
                    while (successor.lchild != null)
                        successor = successor.lchild;
                    p.info = successor.info;
                    p.rchild = DeleteRecursively(p.rchild, successor.info);
                }
                else
                {
                    if (p.lchild != null)
                        ch = p.lchild;
                    else
                        ch = p.rchild;
                    p = ch;
                }
            }

            return p;
        }

        public bool Search(int x)
        {
            Node p = root;

            while (p != null)
            {
                if (x < p.info)
                    p = p.lchild;
                else if (x > p.info)
                    p = p.rchild;
                else
                    return true;
            }

            return false;        
        }

        public bool SearchRecursively(int x)
        {
            return SearchRecursively(root, x) != null;
        }

        public Node SearchRecursively(Node p, int x)
        {
            if(p == null)
                return null;
            if (x < p.info)
                return SearchRecursively(p.lchild, x);
            else if (x > p.info)
                return SearchRecursively(p.rchild, x);
            else
                return p;
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }

        public void PreOrder(Node p)
        {
            if (p == null)
                return;      
            Console.Write(p.info + "  ");
            PreOrder(p.lchild);
            PreOrder(p.rchild);           
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }

        public void InOrder(Node p)
        {
            if (p == null)
                return;                        
            InOrder(p.lchild);
            Console.Write(p.info + "  ");
            InOrder(p.rchild);
        }

        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }

        public void PostOrder(Node p)
        {
            if (p == null)
                return;
            PostOrder(p.lchild);          
            PostOrder(p.rchild);
            Console.Write(p.info + "  ");
        }

        public void LevelOrder()
        {
            if(root == null)
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
                Console.Write(p.info + "  ");
                if(p.lchild != null)
                    queue.Enqueue(p.lchild);
                if (p.rchild != null)
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
            if(p == null)
                return 0;

            int hL = Height(p.lchild);
            int hR = Height(p.rchild);

            if (hL > hR)
                return 1 + hL;
            else
                return 1 + hR;
        }

        public int MinimumKey()
        {
            if (root == null)
                throw new InvalidOperationException("Tree is empty");

            Node p = root;
            while (p.lchild != null)
                p = p.lchild;
            return p.info;
        }

        public int MinimumKeyRecurseively()
        {
            if (root == null)
                throw new InvalidOperationException("Tree is empty");
            return MinimumKeyRecursively(root).info;
        }

        public Node MinimumKeyRecursively(Node p)
        {
            if (p.lchild == null)
                return p;            
            return MinimumKeyRecursively(p.lchild);
        }

        public int MaximumKey()
        {
            if (root == null)
                throw new InvalidOperationException("Tree is empty");

            Node p = root;
            while (p.rchild != null)
                p = p.rchild;

            return p.info;
        }

        public int MaximumKeyRecursively()
        {
            if (root == null)
                throw new InvalidOperationException("Tree is empty");
            return MaximumKeyRecursively(root).info;
        }

        public Node MaximumKeyRecursively(Node p)
        {
            if (p.rchild == null)
                return p;
            return MaximumKeyRecursively(p.rchild); ;
        }
    }
}
