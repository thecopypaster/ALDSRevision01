using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0025.HeapArray
{
    internal class Heap
    {
        private int[] a;
        private int n;

        public Heap()
        {
            a = new int[10];
            n = 0;
            a[0] = 99999;
        }

        public Heap(int maxSize)
        {
            a = new int[maxSize];
            n = 0;
            a[0] = 99999;
        }

        public void Insert(int x)
        {
            n++;
            a[n] = x;
            RestoreUp(n);
        }

        public void RestoreUp(int i)
        {
            int iParent = i / 2;
            int k = a[i];
            while (a[iParent] < k)
            {
                a[i] = a[iParent];                
                i = iParent;
                iParent = iParent / 2;
            }

            a[i] = k;
        }

        public int DeleteRoot()
        {
            if (n == 0)
                throw new InvalidOperationException("Heap is empty");

            int maxElement = a[1];
            a[1] = a[n];
            n--;
            RestoreDown(1);
            return maxElement;
        }

        public void RestoreDown(int i)
        {
            int k = a[i];
            int lchild = 2*i;
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

            if(lchild == n && k < a[lchild])
            {
                a[i] = a[lchild];
                i = lchild;
            }

            a[i] = k;
        }

        public void Display()
        {
            Console.Write("The Heap is: ");
            for (int i = 1; i <= n; i++)
                Console.Write(a[i] + "  ");
        }
    }
}
