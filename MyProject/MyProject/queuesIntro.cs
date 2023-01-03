using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> MyQueue = new Queue<int>();
            MyQueue.Enqueue(10);
            MyQueue.Enqueue(100);
            MyQueue.Enqueue(500);
            MyQueue.Enqueue(1000);
            MyQueue.Dequeue();
            MyQueue.Clear();
            foreach (int i in MyQueue)
            {
                Console.WriteLine(i);
            }
            if (MyQueue.Contains(500))
            {
                Console.WriteLine("Found 500");
            }
            /*
            int[] myarray = new int[MyQueue.Count];
            MyQueue.CopyTo(myarray, 0); // copy queue to array
            foreach(int j in myarray)
            {
                Console.WriteLine(j);
            }
            */
        }
    }
}
