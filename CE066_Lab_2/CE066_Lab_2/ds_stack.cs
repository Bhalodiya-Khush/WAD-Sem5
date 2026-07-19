using System;
using System.Collections.Generic;

namespace Program1
{
    class ds_stack
    {
        static void Main(String[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Push(4);
            st.Push(5);

            int top = st.Peek();
            Console.WriteLine($"Element at top {top}");

            Console.WriteLine("After All insertion");

            while (st.Count != 0)
            {
                Console.WriteLine(st.Peek());
                st.Pop();
            }
        }

    }
}
