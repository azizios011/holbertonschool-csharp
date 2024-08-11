using System;
using System.Text;

/// <summary>
/// Generic Queue class.
/// </summary>
/// <typeparam name="T">Type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Node class representing each element in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value stored in the node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Reference to the next node.
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor to create a new node with a specified value.
        /// </summary>
        /// <param name="value">Value to store in the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Reference to the head of the queue.
    /// </summary>
    private Node head;

    /// <summary>
    /// Reference to the tail of the queue.
    /// </summary>
    private Node tail;

    /// <summary>
    /// Number of nodes in the queue.
    /// </summary>
    private int count;

    /// <summary>
    /// Method to enqueue a new value to the queue.
    /// </summary>
    /// <param name="value">Value to enqueue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Method to dequeue the first value from the queue.
    /// </summary>
    /// <returns>The value dequeued from the queue.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.Value;
        head = head.Next;
        count--;
        return value;
    }

    /// <summary>
    /// Method to peek at the first value in the queue without dequeuing it.
    /// </summary>
    /// <returns>The first value in the queue.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.Value;
    }

    /// <summary>
    /// Method to print all values in the queue starting from the head.
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    /// <summary>
    /// Method to concatenate all values in the queue if the queue is of type string or char.
    /// </summary>
    /// <returns>Concatenated string of all values in the queue.</returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only");
            return null;
        }

        StringBuilder result = new StringBuilder();
        Node current = head;

        while (current != null)
        {
            result.Append(current.Value);
            
            // Add a space if T is string and it's not the last element
            if (typeof(T) == typeof(string) && current.Next != null)
            {
                result.Append(" ");
            }
            
            current = current.Next;
        }

        return result.ToString();
    }

    /// <summary>
    /// Method to return the count of nodes in the queue.
    /// </summary>
    /// <returns>Number of nodes in the queue.</returns>
    public int Count()
    {
        return count;
    }
}
