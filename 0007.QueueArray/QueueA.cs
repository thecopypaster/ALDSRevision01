using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0007.QueueArray
{
    internal class QueueA
    {
        private int front;
        private int rear;
        int[] queueA = null;
        public QueueA()
        {
            front = -1;
            rear = -1;
            queueA = new int[10];
        }

        public QueueA(int maxSize)
        {
            front = -1;
            rear = -1;
            queueA = new int[maxSize];
        }

        public void CreateQueue()
        {
            int n, x;
            Console.Write("Enter number of elements in the Queue: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the element at " + i + " : ");
                x = Convert.ToInt32(Console.ReadLine());
                Enqueue(x);
            }
        }

        public void Enqueue(int x)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full");
            if (front == -1)
                front = 0;

            rear++;
            queueA[rear] = x;
        }

        public int Dequeue()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            int x = queueA[front];
            front++;
            return x;
        }

        public void Display()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty");

            Console.Write("The queue is:  ");

            for (int i = front; i <= rear; i++)
            {
                Console.Write(queueA[i] + " ");
            }
        }

        public int Size()
        {
            if(IsEmpty())
                return 0;
            return (rear - front + 1);
        }

        public bool IsEmpty()
        {
            return (front == -1 || (front == rear + 1));
        }

        public bool IsFull()
        {
            return (rear == (queueA.Length - 1));
        }
    }
}
