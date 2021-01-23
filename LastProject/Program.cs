using System;

namespace LastProject
{
    class Program
    {
        static void Main(string[] args)w
        {
            MyDictionary<int> kisiler = new MyDictionary<int>();

            kisiler.Add(21);
            kisiler.Add(32);
            kisiler.Add(88);

            foreach (var item in kisiler.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
