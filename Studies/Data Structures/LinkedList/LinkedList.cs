namespace Studies.Data_Structures.LinkedList;

public class Node<T>
{
    // Value stored in the node
    public T? Value { get; set; }

    // Reference to the next node
    public Node<T>? Next { get; set; }

    // Reference to the previous node
    public Node<T>? Prev { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
        Prev = null;
    }

    public override string ToString()
    {
        return Value?.ToString() ?? "null";
    }
}

public class LinkedList<T>
{
    private Node<T>? head; // First node in the list
    private Node<T>? tail; // Last node in the list

    // Inserts a new node immediately after an existing node
    public void InsertAfter(Node<T> existingNode, Node<T> newNode)
    {
        newNode.Next = existingNode.Next; // The new node's next points to the existing node's next
        newNode.Prev = existingNode;      // The new node's previous points to the existing node

        if (existingNode.Next != null)
        {
            existingNode.Next.Prev = newNode; // Update the next node’s previous reference
        }

        existingNode.Next = newNode; // Update the existing node to point to the new node

        if (newNode.Next == null)
        {
            tail = newNode; // If the new node is the last one, update the tail
        }
    }

    // Removes a node from the list
    public void Delete(Node<T> node)
    {
        if (node.Prev != null)
        {
            node.Prev.Next = node.Next; // The previous node now points to the next node, skipping the current one
        }
        else
        {
            head = node.Next; // If deleting the first node, update the head
        }

        if (node.Next != null)
        {
            node.Next.Prev = node.Prev; // The next node now points to the previous node, skipping the current one
        }
        else
        {
            tail = node.Prev; // If deleting the last node, update the tail
        }
    }

    // Adds a node at the beginning of the list
    public void AddAtFirst(Node<T> node)
    {
        if (head == null)
        {
            head = tail = node; // If the list is empty, both head and tail point to the new node
        }
        else
        {
            node.Next = head; // The new node points to the current head
            head.Prev = node; // The current head now points back to the new node
            head = node;      // Update head reference
        }
    }

    // Prints the linked list
    public void PrintList()
    {
        Node<T>? current = head;

        while (current != null)
        {
            Console.Write(current.Value);

            if (current.Next != null)
            {
                Console.Write(" <-> ");
            }

            current = current.Next;
        }

        Console.WriteLine();
    }

    // Returns the first node (head) of the list
    public Node<T>? GetHead() => head;

    // Returns the last node (tail) of the list
    public Node<T>? GetTail() => tail;
}
