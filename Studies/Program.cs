using Studies.Algorithms.Search.BinarySearch;
using Studies.Algorithms.Search.LinearSearch;
using Studies.Algorithms.Search.TwoCrystalBallsProblem;
using Studies.Algorithms.Sorting.BubbleSort;
using Studies.BigO;
using Studies.Data_Structures.LinkedList;
using Studies.Data_Structures.Stack;
using Studies.DataStructures.Queue;

namespace Studies;
public class Program
{
    public static void Main(string[] args)
    {
        // Big O Example
        Console.Write("Big O: ");
        Console.WriteLine(BigOExamples.SumCharCodes("something"));
        Console.WriteLine("\n------------------------------------------------------\n");

        // Array Example
        Console.WriteLine("Array:");
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Accessing elements in the array
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);

        // Iterating over the array
        Console.Write("All elements in the array: ");
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine(number);
        //}
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("\n------------------------------------------------------\n");

        // Linear Search
        Console.Write("Linear Search: ");
        int[] haystack = { 1, 8, 15, 18, 32 };
        int needle = 16;

        Console.WriteLine(LinearSearchExample.Linear_Search(haystack, needle));
        Console.WriteLine("\n------------------------------------------------------\n");

        // Binary Search
        Console.Write("Binary Search: ");
        int[] binary = { 1, 2, 3, 4, 5, 6, 7 };
        //int[] binary= Enumerable.Range(1, 10000).ToArray();

        int valueToFind = 4;

        Console.WriteLine(BinarySearchExample.Binary_Search(binary, valueToFind));
        Console.WriteLine("\n------------------------------------------------------\n");

        // Two Crystal Balls Problem
        Console.WriteLine("Two Crystal Balls Problem:");

        bool[] breaks = new bool[100];

        for (int i = 75; i < breaks.Length; i++)
        {
            breaks[i] = true;
        }

        int result = TwoCrystalBalls.TwoCrystalBallsSolution(breaks);
        Console.WriteLine($"Breaking Point Found at Index: {result}");
        Console.WriteLine("\n------------------------------------------------------\n");

        // Bubble Sort
        Console.WriteLine("Bubble Sort:");

        int[] arr = { 1, 4, 0, 5, 9, 7, 2, 3, 6, 8 };

        Console.Write("Array before sorting: ");
        Console.WriteLine(string.Join(", ", arr));

        BubbleSortExample.Bubble_Sort(arr);

        Console.Write("Array after sorting: ");
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine("\n------------------------------------------------------\n");

        // LinkedList
        Console.WriteLine("LinkedList: ");
        LinkedListExample<char> linkedList = new();

        Node<char> a = new('A');
        Node<char> b = new('B');
        Node<char> c = new('C');
        Node<char> d = new('D');
        Node<char> e = new('E');

        linkedList.AddAtFirst(e);
        linkedList.AddAtFirst(d);
        linkedList.AddAtFirst(c);
        linkedList.AddAtFirst(b);
        linkedList.AddAtFirst(a);

        Console.Write("Actual list: ");
        linkedList.PrintList();

        // Insert F between B and C
        Data_Structures.LinkedList.Node<char> f = new('F');
        linkedList.InsertAfter(b,f);

        Console.WriteLine("\nList after inserting 'F' between 'B' and 'C'");
        linkedList.PrintList();

        // Delete C
        linkedList.Delete(c);

        Console.WriteLine("\nList after deleting 'C'");
        linkedList.PrintList();

        // At that time, I didn't know that it could be done using Generics, but below is how it could be done.
        /*
            Console.WriteLine("LinkedList: ");
            LinkedList<char> linkedList = new LinkedList<char>();

            linkedList.AddFirst('E');
            linkedList.AddFirst('D');
            linkedList.AddFirst('C');
            linkedList.AddFirst('B');
            linkedList.AddFirst('A');

            Console.Write("Actual list: ");
            PrintList(linkedList);

            // Insert 'F' between 'B' and 'C'
            var nodeB = linkedList.Find('B');
            if (nodeB != null)
            {
                linkedList.AddAfter(nodeB, 'F');
            }

            Console.WriteLine("\nList after inserting 'F' between 'B' and 'C'");
            PrintList(linkedList);

            // Delete 'C'
            var nodeC = linkedList.Find('C');
            if (nodeC != null)
            {
                linkedList.Remove(nodeC);
            }

            Console.WriteLine("\nList after deleting 'C'");
            PrintList(linkedList);
        }

        static void PrintList(LinkedList<char> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
         */
        
        Console.WriteLine("\n------------------------------------------------------\n");

        // Queue
        Console.WriteLine("Queue: ");
        QueueExample<char> queue = new();

        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');
        queue.Enqueue('D');
        queue.Enqueue('E');

        
        Console.WriteLine("Actual Queue: ");
        queue.PrintQueue();

        Console.WriteLine();
        Console.WriteLine("Queue Length: " + queue.Length);
        Console.WriteLine("Queue Peek: " + queue.Peek());
        Console.WriteLine("\n");

        queue.Dequeue();

        Console.WriteLine("Queue after dequeue method: ");
        queue.PrintQueue();

        Console.WriteLine();
        Console.WriteLine("Queue Length: " + queue.Length);
        Console.WriteLine("Queue Peek: " + queue.Peek());

        // Queue using Generics:
        /*
            Console.WriteLine("Queue: ");
            Queue<char> queue = new();

            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');
            queue.Enqueue('E');

            Console.WriteLine("Actual Queue: ");
            PrintQueue(queue);

            Console.WriteLine();
            Console.WriteLine("Queue Length: " + queue.Count);
            Console.WriteLine("Queue Peek: " + queue.Peek());
            Console.WriteLine("\n");

            queue.Dequeue();

            Console.WriteLine("Queue after dequeue method: ");
            PrintQueue(queue);

            Console.WriteLine();
            Console.WriteLine("Queue Length: " + queue.Count);
            Console.WriteLine("Queue Peek: " + queue.Peek());
        }

        static void PrintQueue(Queue<char> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        } 
         */

        Console.WriteLine("\n------------------------------------------------------\n");

        // Stack
        StackExample<char> stack = new();

        Console.WriteLine("Stack:");

        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        stack.Push('E');

        Console.WriteLine("Actual Stack:");
        stack.PrintStack();

        Console.WriteLine();
        Console.WriteLine("Stack Length: " + stack.Length);
        Console.WriteLine("Stack Peek: " + stack.Peek());
        Console.WriteLine("\n");

        stack.Pop();

        Console.WriteLine("Stack after pop method: ");
        stack.PrintStack();

        Console.WriteLine();
        Console.WriteLine("Stack Length: " + stack.Length);
        Console.WriteLine("Stack Peek: " + stack.Peek());
        
        Console.WriteLine("\n------------------------------------------------------\n");

        // Stack using Generics:
        /*
            Stack<char> stackChar = new Stack<char>();

            Console.WriteLine("Char Stack:");

            stackChar.Push('A');
            stackChar.Push('B');
            stackChar.Push('C');
            stackChar.Push('D');
            stackChar.Push('E');

            Console.WriteLine("Actual Char Stack:");
            PrintStack(stackChar);

            Console.WriteLine();
            Console.WriteLine("Char Stack Length: " + stackChar.Count);
            Console.WriteLine("Char Stack Peek: " + (stackChar.Count > 0 ? stackChar.Peek().ToString() : "Stack is empty"));
            Console.WriteLine("\n");

            stackChar.Pop();

            Console.WriteLine("Char Stack after pop method:");
            PrintStack(stackChar);

            Console.WriteLine();
            Console.WriteLine("Char Stack Length: " + stackChar.Count);
            Console.WriteLine("Char Stack Peek: " + (stackChar.Count > 0 ? stackChar.Peek().ToString() : "Stack is empty"));
            Console.WriteLine("\n------------------------------------------------------\n");
        }

        static void PrintStack(Stack<char> stack)
        {
            Console.WriteLine("-----");
            foreach (var item in stack)
            {
                Console.WriteLine($"| {item} |");
            }
            Console.WriteLine("-----"
         */
    }
}
