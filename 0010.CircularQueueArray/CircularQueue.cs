using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0010.CircularQueueArray
{
    internal class CircularQueue
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public CircularQueue() 
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public CircularQueue(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear= -1;
        }
        public bool IsEmpty()
        {
            return front == -1;
        }

        public bool IsFull()
        {
            return ((front == 0 && rear == queueArray.Length - 1) || (front == rear + 1));
        }

        public void Insert(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow\n");
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

        public int Delete()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");

            int x = queueArray[front];

            //check if queue has only one element to determine if front and rear needs to be set to -1 when 
            //the only element needs to be deleted
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == queueArray.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");
            return queueArray[front];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.Write("Queue is: ");
            int i = front;
            if(front <= rear)
            {
                while (i <= rear)
                    Console.Write(queueArray[i++] + " ");
            }
            else
            {
                while (i <= queueArray.Length - 1)
                    Console.Write(queueArray[i++] + " ");
                i = 0;
                while(i <= rear)
                    Console.Write(queueArray[i++] + " ");
            }

            Console.WriteLine();
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;
            if(IsFull())
                return queueArray.Length;

            int i = front;
            int size = 0;
            if(front <= rear)
                while(i <= rear)
                {
                    size++;
                    i++;
                }
            else
            {
                while(i <= queueArray.Length - 1)
                {
                    size++;
                    i++;
                }
                i = 0;
                while(i <= rear)
                {
                    size++;
                    i++;
                }
            }
            return size;
        }

    }
}
