namespace QueueUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
        }
    }
}