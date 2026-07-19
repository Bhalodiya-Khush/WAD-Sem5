using System;
using System.Collections.Generic;

namespace Program1
{
    class ds_queue
    {
        static void Main(String[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            Console.WriteLine("After Executed Dequeue once");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
