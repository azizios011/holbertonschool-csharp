using System;
using System.Text;

    /// <summary>
    /// Represents a generic queue data structure.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// Represents a node in the queue.
        /// </summary>
        public class Node
        {
            /// <summary>
            /// Gets or sets the value of the node.
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            /// Gets or sets the next node in the queue.
            /// </summary>
            public Node Next { get; set; }

            /// <summary>
            /// Initializes a new instance of the Node class with a given value.
            /// </summary>
            /// <param name="value">The value to set for the new node.</param>
            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        /// <summary>
        /// Initializes a new instance of the Queue class.
        /// </summary>
        public Queue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Adds a new node to the end of the queue.
        /// </summary>
        /// <param name="value">The value to be added to the queue.</param>
        public void Enqueue(T value)
        {
            Node newNode = new Node(value);

            if (tail != null)
            {
                tail.Next = newNode;
            }
            tail = newNode;

            if (head == null)
            {
                head = tail;
            }

            count++;
        }

        /// <summary>
        /// Removes the first node from the queue and returns its value.
        /// </summary>
        /// <returns>The value of the removed node, or default value if the queue is empty.</returns>
        public T Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }

            T value = head.Value;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            count--;
            return value;
        }

        /// <summary>
        /// Returns the value of the first node without removing it.
        /// </summary>
        /// <returns>The value of the first node, or default value if the queue is empty.</returns>
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
        /// Prints all values in the queue from the head to the tail.
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
        /// Returns the number of nodes in the queue.
        /// </summary>
        /// <returns>The number of nodes in the queue.</returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// Concatenates all values in the queue if the queue's type is string or char.
        /// </summary>
        /// <returns>The concatenated string or null if not applicable.</returns>
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
                current = current.Next;
            }

            return result.ToString();
        }
    }
