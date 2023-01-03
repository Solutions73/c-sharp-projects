using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> MyStack = new Stack<int>();
            MyStack.Push(10);
            MyStack.Push(100);
            MyStack.Push(500);
            MyStack.Push(1000);
            MyStack.Pop();
            MyStack.Clear();
     
            foreach (int i in MyStack)
            {
                Console.WriteLine(i);
            }
           
            /*
            int[] MyArray = new int[MyStack.Count];
            MyStack.CopyTo(MyArray, 0);
            foreach (int j in MyArray)
            {
                Console.WriteLine(j);
            }
            

            int k = MyStack.Count;
            Console.WriteLine(k);
            if (MyStack.Contains(500))
            {
                Console.WriteLine("Found 500");
            }
            */
        }
    }
}
