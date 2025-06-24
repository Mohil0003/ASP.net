using System;
using System.Collections.Generic;

namespace Lab_Stack
{
    public class IntegerStack
    {
        Stack<int> stack = new Stack<int>();

        public void Push(int item)
        {
            stack.Push(item);
            Console.WriteLine($"{item} pushed into stack.");
        }


        public void Pop()
        {
            if (stack.Count > 0)
            {
                int removed = stack.Pop();
                Console.WriteLine($"{removed} popped from stack.");
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
            }
        }

        public void Peek()
        {
            if (stack.Count > 0)
            {
                int top = stack.Peek();
                Console.WriteLine($"Top item is: {top}");
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }

        public void Contains(int item)
        {
            if (stack.Contains(item))
            {
                Console.WriteLine($"{item} exists in the stack.");
            }
            else
            {
                Console.WriteLine($"{item} does not exist in the stack.");
            }
        }

        public void Clear()
        {
            stack.Clear();
            Console.WriteLine("Stack cleared.");
        }

        public void Display()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Current Stack:");
                foreach (int item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
