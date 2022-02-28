using System;

namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks and Queues");
            Queue queue = new Queue();
            queue.Push(56);
            queue.Push(30);
            queue.Push(70);
            queue.Dequeue();
            queue.DisplayQueue();

        }
    }
}