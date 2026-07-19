using System;
using System.Collections.Generic;

namespace prog1
{
    class ds_List
    {
        static void Main(String[] arg)
        {
            List<int> numbers = new List<int>() { 9, 99, 100 };
            numbers.Add(1000);
            numbers.Insert(4, 1001);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
