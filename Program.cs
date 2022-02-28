using System;

namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks and Queues");
            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Peek_Pop();
            stack.DisplayStack();

        }
    }
}