using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0014.InfixToPostFixUsingStack
{
    internal class StackInt
    {
        private int[] stackAray;
        private int top;

        public StackInt()
        {
            top = -1;
            stackAray = new int[10];
        }

        public StackInt(int maxSize)
        {
            top = -1;
            stackAray = new int[maxSize];
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
            return (top == stackAray.Length - 1);
        }

        public void Push(int x)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Stack overflow");
            }

            top++;
            stackAray[top] = x;
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }

            x = stackAray[top];
            top--;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }

            return stackAray[top];
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
            {
                Console.Write(stackAray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
