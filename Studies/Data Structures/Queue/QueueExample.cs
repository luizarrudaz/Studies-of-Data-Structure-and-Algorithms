namespace Studies.DataStructures.Queue
{
    public class Node<T>
    {
        public T Value { get; }
        public Node<T>? Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class QueueExample<T>
    {
        public int Length { get; private set; }
        private Node<T>? Head;
        private Node<T>? Tail;

        public QueueExample()
        {
            Head = Tail = null; // Initialize Head and Tail to null
            Length = 0; // Initialize Length to 0
        }

        public void Enqueue(T value)
        {
            var newNode = new Node<T>(value); // Create a new node with the given value

            if (Tail == null) // If the queue is empty, both Head and Tail will point to the new node
            {
                Head = Tail = newNode;
            }
            else // If the queue is not empty, add the new node at the end and update Tail
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            Length++;
        }

        public T? Dequeue()
        {
            if (Head == null) // If the queue is empty, throw an exception
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var oldHead = Head; // Save the current head to return its value
            Head = Head.Next; // Move the Head pointer to the next node in the queue

            if (Head == null) // If the queue becomes empty after removal, set Tail to null
            {
                Tail = null;
            }

            Length--;
            return oldHead.Value; // Return the value of the old head
        }

        // Returns the value of the Head
        public T? Peek()
        {
            if (Head == null) // If the queue is empty, return default
            {
                return default;
            }

            return Head.Value;
        }

        // Checks if the queue is empty
        public bool IsEmpty() => Length == 0; // Return true if the length is 0

        public void PrintQueue()
        {
            var current = Head;
            while (current != null)
            {
                Console.Write(current.Value);

                if (current.Next != null)
                {
                    Console.Write(" --> ");
                }

                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}