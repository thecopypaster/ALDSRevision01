using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0011.DequeCircularArray
{
    internal class Deque
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public Deque()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public Deque(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public void InsertFront(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow");
                return;
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
                front = queueArray.Length - 1;
            else
                front = front - 1;
            queueArray[front] = x;
        }

        public void InsertRear(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow");
                return;
            }

            if (front == -1)
                front = 0;
            if (rear == queueArray.Length - 1)
                rear = 0;
            else
                rear = rear + 1;
            queueArray[rear] = x;
        }

        public int DeleteFront()
        {
            int x;
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");

            x = queueArray[front];
            if (front == rear)
                front = rear = -1;
            else if (front == queueArray.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }

        public int DeleteRear()
        {
            int x;
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");

            x = queueArray[rear];
            if (front == rear)
                front = rear = -1;
            else if (rear == 0)
                rear = queueArray.Length - 1;
            else
                rear = rear - 1;
            return x;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.Write("The Queue is: ");

            int i = front;
            if (front <= rear)
            {
                while (i <= rear)
                    Console.Write(queueArray[i++] + " ");
            }
            else
            {
                while (i <= queueArray.Length - 1)
                    Console.Write(queueArray[i++] + " ");
                i = 0;
                while (i <= rear)
                    Console.Write(queueArray[i++] + " ");
            }
            Console.WriteLine();
        }

        public int Size()
        {
            int count = 0;
            if (IsEmpty())
                return 0;
            if (IsFull())
                return queueArray.Length;

            int i = front;
            if (front <= rear)
            {
                while (i <= rear)
                {
                    count++;
                    i++;
                }
            }
            else
            {
                while (i <= queueArray.Length - 1)
                {
                    count++;
                    i++;
                }

                i = 0;
                while (i <= rear)
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");
            return queueArray[front];
        }

        public bool IsFull()
        {
            return (front == rear + 1 || (front == 0 && rear == queueArray.Length - 1));
        }

        public bool IsEmpty()
        {
            return front == -1;
        }
    }
}
