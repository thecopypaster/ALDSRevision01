using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0013.ValidateParenthesisWithStack
{
    internal class StackA
    {
        private char[] stackArray;
        private int top;

        public StackA()
        {
            stackArray = new char[10];
            top = -1;
        }

        public StackA(int maxSize)
        {
            stackArray = new char[maxSize];
            top = -1;
        }


        public void Push(char x)
        {
            if (IsFull())
                throw new InvalidOperationException("Stack overflow");

            top++;
            stackArray[top] = x;
        }

        public char Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack unfderflow");
            char x = stackArray[top];
            top--;
            return x;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");
            return stackArray[top];
        }

        public int Size()
        {
            return top + 1;
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
                Console.Write(stackArray[i] + " ");
            }            

            Console.WriteLine();
        }
    }
}
