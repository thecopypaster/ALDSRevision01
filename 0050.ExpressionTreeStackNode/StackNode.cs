using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0050.ExpressionTreeStackNode
{
    internal class StackNode
    {
        private Node[] stackA;
        private int top;

        public StackNode()
        {
            stackA = new Node[10];
            top = -1;
        }

        public StackNode(int maxSize)
        {
            stackA = new Node[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == (stackA.Length - 1));
        }

        public void Push(Node x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack overflow");
                return;
            }

            top++;
            stackA[top] = x;
        }

        public Node Pop()
        {
            if (IsEmpty())
            {                
                throw new InvalidOperationException("Stack Underflow");
            }

            Node node = stackA[top];
            top--;
            return node;
        }

        public Node Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow\n");
                throw new System.InvalidOperationException();
            }
            return stackA[top];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("The stack is: ");
            for (int i = top; i >= 0; i--)
                Console.Write(stackA[i].info + "  ");

            Console.WriteLine();
        }
    }
}
