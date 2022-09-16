using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0006.StackLinkedList
{
    internal class StackL
    {
        private Node top;

        public StackL()
        {
            top = null;
        }

        public void CreateStack()
        {
            int n, x;
            Console.Write("Enter number of elements in the stack: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the element at " + i + " : ");
                x = Convert.ToInt32(Console.ReadLine());
                Push(x);
            }           
            
        }

        public bool IsEmpty() 
        {
            return top == null;
        }       
        

        public int Size()
        {
            int count = 0;
            Node p = top;
            while (p != null)
            {
                count++;
                p = p.link;
            }

            return count;
        }
       

        public void Push(int x)
        {
            Node temp = new Node(x);

            if(top == null)
            {
                top = temp;
                return;
            }                

            temp.link = top;
            top = temp;
        }


        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow");

            int x = top.info;
            top = top.link;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow");
            return top.info;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("The stack is: ");

            Node p = top;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }

            Console.WriteLine();
        }
    }
}
