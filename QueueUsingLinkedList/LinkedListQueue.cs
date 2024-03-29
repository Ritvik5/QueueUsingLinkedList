﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    public class LinkedListQueue
    {
        public Node front;
        public Node rear;

        public LinkedListQueue()
        {
            this.front = null;
            this.rear = null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);


            if (this.rear == null)
            {
                this.front = newNode;
                this.rear = newNode;
            }
            else
            {

                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", data);
        }

        public void Display()
        {
            Node temp = this.front;

            if (temp == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Console.Write("Queue: ");
            while (temp != null)
            {
                Console.Write("{0} ", temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }
    }

}
