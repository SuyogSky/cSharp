using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Push (T item)
        {
            this.items.Add(item);
        } 

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                T lastItem = items[this.items.Count - 1];
                items.RemoveAt(this.items.Count - 1);
                return lastItem;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                T lastItem = items[this.items.Count - 1];
                return lastItem;
            }
        }
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void DisplayStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty.");
            }
            else
            {
                for (int i = this.items.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }
    }
}
