using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedList<string> MyLL = new linkedList<string>();
            MyLL.AddLast("orange");
            MyLL.AddFirst("apple");
            MyLL.AddLast("Cherry");
            MyLL.AddFirst("banana");

            LinkedListNode<string> i = MyLL.Find("banana");
            MyLL.AddBefore(i, "Fruit:");
            MyLL.Remove("banana");
            MyLL.RemoveLast();

            foreach (var fruit in MyLL)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
