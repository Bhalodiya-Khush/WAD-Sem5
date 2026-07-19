using System;
using System.Collections.Generic;

namespace Program1
{
    class ds_dict
    {
        static void Main(String[] arg)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>() { { 1, 10 }, { 2, 20 } };
            dict.Add(3, 30);
            dict.Add(4, 40);
            dict[5] = 50;

            foreach (var item in dict)
            {
                Console.WriteLine($"Key : {item.Key} and Value : {item.Value}");
            }

            dict.Remove(4);
            Console.WriteLine("After Removing");

            foreach (var item in dict)
            {
                Console.WriteLine($"Key : {item.Key} and Value : {item.Value}");
            }
        }
    }
}
