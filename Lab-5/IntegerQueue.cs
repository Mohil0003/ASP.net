using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
        public class IntegerQueue
        {
            Queue<int> queue = new Queue<int>();

            public void Enqueue(int item)
            {
                queue.Enqueue(item);
                Console.WriteLine($"{item} enqueued into the queue.");
            }

            public void Dequeue()
            {
                if (queue.Count > 0)
                {
                    int removed = queue.Dequeue();
                    Console.WriteLine($"{removed} dequeued from the queue.");
                }
                else
                {
                    Console.WriteLine("Queue is empty. Cannot dequeue.");
                }
            }

            public void Peek()
            {
                if (queue.Count > 0)
                {
                    int front = queue.Peek();
                    Console.WriteLine($"Front item is: {front}");
                }
                else
                {
                    Console.WriteLine("Queue is empty.");
                }
            }

            public void Contains(int item)
            {
                if (queue.Contains(item))
                {
                    Console.WriteLine($"{item} exists in the queue.");
                }
                else
                {
                    Console.WriteLine($"{item} does not exist in the queue.");
                }
            }

            public void Clear()
            {
                queue.Clear();
                Console.WriteLine("Queue cleared.");
            }

            public void Display()
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Queue is empty.");
                }
                else
                {
                    Console.WriteLine("Current Queue:");
                    foreach (int item in queue)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
