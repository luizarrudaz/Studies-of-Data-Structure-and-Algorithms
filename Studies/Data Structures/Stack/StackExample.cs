namespace Studies.Data_Structures.Stack
{
    public class SNode<T>
    {
        public T? Value { get; set; } 
        public SNode<T>? Prev { get; set; }

        // Constructor to initialize the node with a value and an optional reference to the previous node
        public SNode(T value, SNode<T>? prev = null)
        {
            Value = value;
            Prev = prev; // Connects the new node to the previous node (if any)
        }
    }

    public class StackExample<T>
    {
        public int Length { get; private set; } 
        private SNode<T>? Head; // Represents the top of the stack

        public StackExample()
        {
            Head = null; // Initially, the stack is empty
            Length = 0; // The stack length starts at 0
        }

        // Adds a new element to the top of the stack
        public void Push(T Item)
        {
            Head = new SNode<T>(Item, Head); // The new node points to the previous top node
            Length++;
        }

        // Removes and returns the element from the top of the stack
        public T? Pop()
        {
            if (Head == null) // If the stack is empty, return the default value for T
            {
                return default;
            }

            T? value = Head.Value; // Save the value of the top node
            Head = Head.Prev; // Move the top pointer to the previous node
            Length--; 

            return value; // Return the value of the removed node
        }

        public T? Peek() 
        { 
            if (Head == null) { return default; } 
            return Head.Value; 
        }

        public bool IsEmpty => Length == 0; 

        public void PrintStack()
        {
            var current = Head;
            var builder = new System.Text.StringBuilder();
            builder.AppendLine("-----");

            while (current != null)
            {
                builder.AppendLine($"| {current.Value} |");
                current = current.Prev;
            }

            builder.AppendLine("-----");
            Console.WriteLine(builder.ToString());
        }
    }
}