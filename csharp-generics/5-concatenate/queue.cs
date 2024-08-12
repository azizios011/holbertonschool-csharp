using System;
using System.Text;

/// <summary>
/// A generic queue class implementation.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Node class representing each element in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T value;

        /// <summary>
        /// Pointer to the next node in the queue.
        /// </summary>
        public Node next;

        /// <summary>
        /// Initializes a new node with the specified value.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    // Queue properties
    private Node head;
    private Node tail;
    private int count;

    /// <summary>
    /// Adds a new element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Removes and returns the element at the front of the queue.
    /// </summary>
    /// <returns>The value of the removed element, or the default value if the queue is empty.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = head.value;
        head = head.next;
        count--;
        return value;
    }

    /// <summary>
    /// Returns the value of the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The value of the first element, or the default value if the queue is empty.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// Prints all the elements in the queue, starting from the head.
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
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>
    /// Concatenates all the values in the queue if the queue is of type string or char.
    /// </summary>
    /// <returns>A concatenated string of all values, or null if the queue is empty or not of type string/char.</returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (CheckType() == typeof(string))
        {
            StringBuilder sb = new StringBuilder();
            Node current = head;
            while (current != null)
            {
                sb.Append(current.value);
                if (current.next != null)
                {
                    sb.Append(" ");
                }
                current = current.next;
            }
            return sb.ToString();
        }
        else if (CheckType() == typeof(char))
        {
            StringBuilder sb = new StringBuilder();
            Node current = head;
            while (current != null)
            {
                sb.Append(current.value);
                current = current.next;
            }
            return sb.ToString();
        }
        else
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }
    }

    /// <summary>
    /// Returns the number of elements in the queue.
    /// </summary>
    /// <returns>The count of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Checks and returns the type of the queue's elements.
    /// </summary>
    /// <returns>The type of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
