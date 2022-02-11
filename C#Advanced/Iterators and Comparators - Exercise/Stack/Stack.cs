using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> stack = new List<T>();

        public Stack()
        {

        }

        public void Pop()
        {
            if (stack.Count==0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                stack.RemoveAt(stack.Count-1);
            }
        }

        public void Push(T element)
        {
            stack.Insert(stack.Count,element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
